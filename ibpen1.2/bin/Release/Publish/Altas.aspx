<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Altas.aspx.cs" Inherits="ibpen1._2.Altas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
            .form-group {
            height: 84px;
            width: 1025px;
        }
        .box-body {
            width: 261px;
        }
        .box-primary {
            height: 753px;
        }
            .col-md-6 {
                height: 109px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
     <form id="form1" runat="server">

            <section>
              <h1 style="text-align:center">Altas</h1>
            </section>
         <section class="content">
             <div> Aula&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Secretaria&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Profesor&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Materia&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Alumno&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                 Nota</div>
                 <div class="row">
                       <div class="col-md-6">
                           <div class="box-body">
                       <div class="form-group">
                           <asp:DropDownList ID="DropDownListAula" runat="server" Height="32px" OnSelectedIndexChanged="DropDownListAula_SelectedIndexChanged" Width="174px" AppendDataBoundItems="True" BackColor="White" CausesValidation="True">
                               <asp:ListItem>--Seleccione Aula--</asp:ListItem>
                           </asp:DropDownList>
                           <asp:DropDownList ID="DropDownListSec" runat="server" Height="32px" Width="174px" OnSelectedIndexChanged="DropDownListSec_SelectedIndexChanged" AppendDataBoundItems="True" CausesValidation="True">
                               <asp:ListItem>--Seleccione Secretaria--</asp:ListItem>
                           </asp:DropDownList>

                           <asp:DropDownList ID="DropDownListPro" runat="server" Height="32px" Width="174px" OnSelectedIndexChanged="DropDownListPro_SelectedIndexChanged" AppendDataBoundItems="True" CausesValidation="True">
                               <asp:ListItem>--Seleccione Profesor--</asp:ListItem>
                           </asp:DropDownList>
                           <asp:DropDownList ID="DropDownListMateria" runat="server" Height="32px" Width="174px" OnSelectedIndexChanged="DropDownListMateria_SelectedIndexChanged" AppendDataBoundItems="True" CausesValidation="True">
                               <asp:ListItem>--Seleccione Materia--</asp:ListItem>
                           </asp:DropDownList>
                           <asp:DropDownList ID="DropDownListAlu" runat="server" Height="32px" Width="174px" OnSelectedIndexChanged="DropDownListAlu_SelectedIndexChanged" AppendDataBoundItems="True" CausesValidation="True">
                               <asp:ListItem>--Seleccione Alumno--</asp:ListItem>
                           </asp:DropDownList>
                           <asp:DropDownList ID="DropDownListNota" runat="server" Height="32px" Width="74px" OnSelectedIndexChanged="DropDownListNota_SelectedIndexChanged">
                               <asp:ListItem>1</asp:ListItem>
                               <asp:ListItem>2</asp:ListItem>
                               <asp:ListItem>3</asp:ListItem>
                               <asp:ListItem>4</asp:ListItem>
                               <asp:ListItem>5</asp:ListItem>
                               <asp:ListItem>6</asp:ListItem>
                               <asp:ListItem>7</asp:ListItem>
                               <asp:ListItem>8</asp:ListItem>
                               <asp:ListItem>9</asp:ListItem>
                               <asp:ListItem>10</asp:ListItem>
                               <asp:ListItem>A</asp:ListItem>
                               <asp:ListItem>M</asp:ListItem>
                               <asp:ListItem>B</asp:ListItem>
                           </asp:DropDownList>
                       </div>
                               </div>
                           </div>
                     <div class="col-md-6">

                         <asp:Button ID="btnGuardar" runat="server" OnClick="Button1_Click" Text="Guardar" Width="157px " />
                      
                     </div>
                  </div>
         </section>

     </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
