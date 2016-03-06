<%@ Page Title="" Language="C#" MasterPageFile="~/Encargado.Master" AutoEventWireup="true" CodeBehind="CRUDUsuario.aspx.cs" Inherits="UI.CRUDS.CRUDUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <style type="text/css">
        .auto-style1 {
            height: 48px;
        }
        .auto-style2 {
            height: 57px;
        }
        .auto-style3 {
            height: 56px;
        }
        .auto-style4 {
            height: 48px;
            width: 121px;
        }
        .auto-style5 {
            height: 57px;
            width: 121px;
        }
        .auto-style6 {
            height: 56px;
            width: 121px;
        }
        .auto-style7 {
            height: 48px;
            width: 305px;
        }
        .auto-style8 {
            height: 57px;
            width: 305px;
        }
        .auto-style9 {
          height: 45px;
      }
      .auto-style10 {
          height: 45px;
          width: 121px;
      }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Cédula:"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label3" runat="server" Text="Primer Apellido:"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="txtPrimerApellido" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label4" runat="server" Text="Segundo Apellido:"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="txtSegundoApellido" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style9">
            <asp:Label ID="Label5" runat="server" Text="Departamento:"></asp:Label>
        </td>
        <td class="auto-style9">
            &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlDepartamento" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDepartamento" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style9">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label6" runat="server" Text="Ocupación:"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="txtOcupacion" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Label ID="Label7" runat="server" Text="Contraseña:"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label8" runat="server" Text="Correo Electrónico:"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="txtCorreoElectronico" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label9" runat="server" Text="Telefono Celular:"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="txtTelefonoCelular" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
        </td>
        <td class="auto-style9">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        </td>
        <td class="auto-style3">
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label10" runat="server" Text="Usuario en Línea:"></asp:Label>
        </td>
        <td class="auto-style8">
            <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
