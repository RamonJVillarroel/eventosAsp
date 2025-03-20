<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="testweb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%//autogenerate columns por defecto viene en true %>
    <div class="m-3 col-4">
        <div class="mb-3">
            <label for="txtId" class="form-label">Id</label>
            <asp:TextBox ID="txtId" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtCalle" class="form-label">Calle</label>
            <asp:TextBox ID="txtCalle" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtAltura" class="form-label">Altura</label>
            <asp:TextBox ID="txtAltura" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="txtEnviarDir" CssClass="btn btn-primary" OnClick="txtEnviarDir_Click" runat="server" Text="Enviar direccion" />

    </div>
    <div class="row">
        <div class="col">
            <asp:GridView ID="dgvDireccion" OnLoad="dgvDireccion_Load" OnSelectedIndexChanged="dgvDireccion_SelectedIndexChanged" DataKeyNames="Id" CssClass="m-3 col-4 table-success" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id" />
                    <asp:BoundField HeaderText="Altura" DataField="Altura" />
                    <asp:BoundField HeaderText="Calle" DataField="Calle" />
                    <asp:CommandField ShowHeader="true" ShowSelectButton="true" HeaderText="Editar" SelectText="Editar" />
                </Columns>
            </asp:GridView>


        </div>
    </div>
    </div>

</asp:Content>
