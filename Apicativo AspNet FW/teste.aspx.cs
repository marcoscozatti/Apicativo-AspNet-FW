using Apicativo_AspNet_FW.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Data.SqlClient;
using System.Data;



namespace Apicativo_AspNet_FW
{
	public partial class teste : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnConecta_Click(object sender, EventArgs e)
		{
			////////////////////////////////////////////////
			//ConectaBD.conecta();
			//MessageBox.Show("Conectado!!!");

			//---- método de inserir

			SqlConnection sqlCon = null;
			//private string strSql = string.Empty;
			string strSql;
			string strCon = @"Data Source=DESKTOP-SEV4FT3\SQLEXPRESS;Initial Catalog=TesteDB1;Integrated Security=True";
			strSql = "INSERT INTO sala ([professor], [sala]) VALUES ('" + txtProfessor.Text + "', '" + txtSala.Text + "')";
			sqlCon = new SqlConnection(strCon);
			SqlCommand comando = new SqlCommand(strSql, sqlCon);
			sqlCon.Open();
			comando.ExecuteNonQuery();
			MessageBox.Show("Registro adicionado");

			

			//cn.Parameters.Add("professor", SqlDbType.VarChar).Value = txtProfessor.Text;
			//cn.Parameters.Add("sala", SqlDbType.VarChar).Value = txtSala.Text;

		}
	}
}