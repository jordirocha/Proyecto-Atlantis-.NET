using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PanelEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DALEvento eventos = new DALEvento();
            GridView1.DataSource = eventos.seleccionarEventos();
            GridView1.DataBind();
            Label1.Visible = false;
        }
     
        protected void ButInsertEvento(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            Stream stream = postedFile.InputStream;
            BinaryReader binaryReader = new BinaryReader(stream);
            byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
            // Insert nuevo evento
            DbConnection con = new DbConnection();
            SqlCommand cmd = new SqlCommand("insertarEvento", con.Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter pNombre = new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 100);
            pNombre.Value = TextBox1.Text;
            cmd.Parameters.Add(pNombre);
            cmd.ExecuteNonQuery();
            Label1.Visible = true;
        }
    }
}