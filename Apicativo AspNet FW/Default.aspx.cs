using Apicativo_AspNet_FW.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services.Description;
using System.Windows;

namespace Apicativo_AspNet_FW
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ConectaBD.conecta();
		 
		}

		protected void btnConecta_Click(object sender, EventArgs e)
		{
			ConectaBD.conecta();
			MessageBox.Show("Banco conectado");
		}

		protected void btnTeste_Click(object sender, EventArgs e)
		{
			Server.Transfer("teste.aspx");
		}


	}
}