using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprobacionListasBCSharp {
	public partial class Form1 : Form {
		public string FicheroDondeGrabar {
			get {
				return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"FicheroConLasUltimasPersonasGrabadas.txt");
			}
		}
		public const string url = @"http://www.xunta.es/rcp/listas/rcp_li05/li05_lista_ambito_sel.jsp?rcpCOD_LISTA=76&rcpCOD_AMBITO=U0000&rcpDES_AMBITO=AMBITO%20AUTON%D3MICO&lang=gl";
		protected List<string> lNombre = new List<string>();
		public Form1() {
			InitializeComponent();
		}

		private async void btnDiferencias_Click(object sender, EventArgs e) {
			this.textBox1.Clear();
			await CargarLista();
			try {
				string[] NombresFich = File.ReadAllLines(FicheroDondeGrabar);
				int i = 0;
				foreach (string item in NombresFich) {
					if (item.Equals(this.lNombre[i])) {
						Mensaje("Igual:" + item);
					} else {
						Mensaje($"DIFERENTES: Antes: {item}, Ahora:{this.lNombre[i]}");
					}
					i++;
				}
			} catch (IOException) {
				Mensaje("Genere el fichero antes de comprobar si los nombres son iguales a los últimos grabados");
			}
		}

		private async Task CargarLista() {
			Mensaje("Leyendo:" + this.FicheroDondeGrabar);
			ScrapingBrowser Browser = new ScrapingBrowser();
			Browser.UserAgent = new FakeUserAgent("primero", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:27.0) Gecko/20100101 Firefox/27.0");
			Browser.AllowAutoRedirect = true; // Browser has settings you can access in setup
			Browser.AllowMetaRedirect = true;
			WebPage PageResult = await Browser.NavigateToPageAsync(new Uri(url));
			IEnumerable<HtmlNode> TDs = PageResult.Html.SelectNodes("//td[@align='left']");
			this.lNombre.Clear();
			foreach (HtmlNode item in TDs) {
				this.lNombre.Add(item.InnerText);
			}
		}

		private void Mensaje(string cad) {
			this.textBox1.Text += cad + Environment.NewLine;
		}

		private async void btnGrabarNuevosDatos_Click(object sender, EventArgs e) {
			if (this.lNombre.Count == 0) {
				await CargarLista();
			}
			File.WriteAllLines(FicheroDondeGrabar, this.lNombre.ToArray());
		}

		private void btnAbrirLaWeb_Click(object sender, EventArgs e) {
			Process.Start(url);
		}
	}
}
