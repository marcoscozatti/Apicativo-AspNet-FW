using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Apicativo_AspNet_FW.App_Start
{
	public class ConectaBD
	{
		public static SqlConnection conecta()
		{

			string conexao = @"Data Source=DESKTOP-SEV4FT3\SQLEXPRESS;Initial Catalog=TesteDB1;Integrated Security=True";
			SqlConnection cn = new SqlConnection(conexao);
			cn.Open();
			
			return cn;
		}	
	}




}