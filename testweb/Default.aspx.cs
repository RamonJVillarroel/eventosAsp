using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using Direccion;
namespace testweb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["listaDireccion"] == null)
                {
                    NegocioDirecion negocio = new NegocioDirecion();
                    Session.Add("listaDireccion", negocio.DireccionListar());
                }

                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    List<Direccion.Direccion> temp = (List<Direccion.Direccion>)Session["listaDireccion"];
                    Direccion.Direccion seleccionado = temp.Find(x => x.Id == id);
                    if (seleccionado != null)
                    {
                        txtId.Text = seleccionado.Id.ToString();
                        txtCalle.Text = seleccionado.Calle;
                        txtAltura.Text = seleccionado.Altura.ToString();
                    }
                }
            }
        }


        protected void dgvDireccion_Load(object sender, EventArgs e)
        {

            dgvDireccion.DataSource = Session["listaDireccion"];
            dgvDireccion.DataBind();

        }

        protected void txtEnviarDir_Click(object sender, EventArgs e)
        { 
            List<Direccion.Direccion> temp = (List<Direccion.Direccion>)Session["listaDireccion"];
            Direccion.Direccion direccionnew = new Direccion.Direccion();
            direccionnew.Id = int.Parse(txtId.Text);
            int num = temp.FindIndex(x=> x.Id == direccionnew.Id);
            if (num < 0)
            {
                var altura = int.Parse(txtAltura.Text);
                var calle = txtCalle.Text;
                direccionnew.Id = int.Parse(txtId.Text);
                direccionnew.Calle = calle;
                direccionnew.Altura = altura;
                temp.Add(direccionnew);
                Response.Redirect("Default.aspx");
            }
            else {
                direccionnew.Calle = txtCalle.Text;
                direccionnew.Altura= int.Parse(txtAltura.Text);
                temp[num].Id = direccionnew.Id;
                temp[num].Calle = direccionnew.Calle;
                temp[num].Altura = direccionnew.Altura;
               
            }
            Session["listaDireccion"] = temp;
            Response.Redirect("Default.aspx");

        }
        protected void dgvDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvDireccion.SelectedDataKey.Value.ToString();
            Response.Redirect("Default.aspx?id=" + id);
        }

        protected void dgvDireccion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            List<Direccion.Direccion> temp = (List<Direccion.Direccion>)Session["listaDireccion"];
            
            var id = e.Keys["Id"].ToString();
            int buscar = int.Parse(id);
            int num= temp.FindIndex(x => x.Id == buscar);
            if (num>=0)
            {
                temp.RemoveAt(num);
            }
            Session["listaDireccion"] = temp;
            Response.Redirect("Default.aspx");

        }
    }
}