<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Profesor.aspx.cs" Inherits="ibpen1._2.Profesor" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style type="text/css">
        .form-group {
            height: 61px;
            width: 981px;
        }
        .box-body {
            width: 431px;
        }
        .box-primary {
            height: 753px;
        }
    .col-md-6 {
        height: 514px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
     <form id="form1" runat="server">
    <section>
        <h1 style="text-align:center">Registro de Datos</h1>
    </section>
   <section class="content">
       <h2>Profesor</h2>
       <div class="row">
           <div class="col-md-6">
               
           

                   <div class="box-body">
                       <div class="form-group">
                           <label>Documento</label>
                           <div class="form-group">
                               <asp:TextBox ID="txtDniP" runat="server" Height="24px" Width="423px"></asp:TextBox>
                           </div>

                       </div>
                        <div class="form-group">
                           <label>Apellido</label>
                           <div class="form-group">
                               <asp:TextBox ID="txtNombreP" runat="server" Height="24px" Width="423px"></asp:TextBox>
                           </div>

                       </div>
                         <div class="form-group">
                           <label>Telefono</label>
                           <div class="form-group">
                               <asp:TextBox ID="txtTelefonoP" runat="server" Height="24px" Width="423px"></asp:TextBox>
                               
                           </div>
                                 <asp:Button ID="btnIngresarPro" runat="server" Height="28px" Text="Ingresar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF" OnClick="btnIngresarP_Click" />
                                 <asp:Button ID="btnActualizarPro" runat="server" Height="28px" Text="Actualizar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF" OnClick="btnActualizarP_Click" />
                                 <asp:Button ID="btnEliminarPro" runat="server" Height="28px" Text="Eliminar" Width="91px" BackColor="Red" BorderColor="#0066FF" OnClick="btnEliminarP_Click" />
                                 <asp:Button ID="btnBuscarPro" runat="server" Height="28px" Text="Mostrar" Width="91px" BackColor="#66CCFF" BorderColor="#0066FF" OnClick="btnBuscarP_Click" />


                             <br />
                          
                             <br />


                       </div>
                   </div>
                       
                           
                             <asp:GridView ID="GridView1Pro" runat="server" BackColor="#99CCFF" Width="828px" style="margin-top: 88px; margin-left: 0px;" Height="198px">
                                 <Columns>
                                     <asp:TemplateField>
                                         <EditItemTemplate>
                                             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                         </EditItemTemplate>
                                         <ItemTemplate>
                                             <asp:Label ID="Label1" runat="server"></asp:Label>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                 </Columns>
                             </asp:GridView>
                                

                       
                      
               </div>
           

       </div>
   </section>
        

      
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
