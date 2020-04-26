<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Admistrador.aspx.cs" Inherits="ibpen1._2.CopiaMaster" %>
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <form id="form1" runat="server">
    <section>
        <h1 style="text-align:center">Registro de Datos</h1>
    </section>
   <section class="content">
       <h2>Secretaria</h2>
       <div class="row">
           <div class="col-md-6">
               
           

                   <div class="box-body">
                       <div class="form-group">
                           <label>Documento</label>
                           <div class="form-group">
                               <asp:TextBox ID="txtDni" runat="server" Height="24px" Width="423px"></asp:TextBox>
                           </div>

                       </div>
                        <div class="form-group">
                           <label>Apellido</label>
                           <div class="form-group">
                               <asp:TextBox ID="txtNombre" runat="server" Height="24px" Width="423px"></asp:TextBox>
                           </div>

                       </div>
                         <div class="form-group">
                           <label>Telefono</label>
                           <div class="form-group">
                               <asp:TextBox ID="txtTelefono" runat="server" Height="24px" Width="423px"></asp:TextBox>
                               
                           </div>
                                 <asp:Button ID="btnIngresarA" runat="server" Height="28px" Text="Ingresar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF" OnClick="btnIngresarA_Click" />
                                 <asp:Button ID="btnActualizarA" runat="server" Height="28px" Text="Actualizar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF" OnClick="btnActualizarA_Click" />
                                 <asp:Button ID="btnEliminarA" runat="server" Height="28px" Text="Eliminar" Width="91px" BackColor="Red" BorderColor="#0066FF" OnClick="btnEliminarA_Click" />
                                 <asp:Button ID="btnBuscarA" runat="server" Height="28px" Text="Mostrar" Width="91px" BackColor="#66CCFF" BorderColor="#0066FF" OnClick="btnBuscarA_Click" />


                             <br />
                          
                             <br />


                       </div>
                   </div>
                       
                           
                             <asp:GridView ID="GridView1Admin" runat="server" BackColor="#99CCFF" Width="828px" style="margin-top: 88px; margin-left: 0px;" Height="198px">
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
   </section><!--
        <section class="content">
       <h2>Profesores</h2>
       <div class="row">
           <div class="col-md-6">
               <div class="box-primary">
                   <div class="box-body">
                       <div class="form-group">
                           <label>Documento</label>
                           <div class="form-group">
                               <asp:TextBox ID="txtProDoc" runat="server" Height="24px" Width="370px"></asp:TextBox>
                           </div>

                       </div>
                        <div class="form-group">
                           <label>Apellido</label>
                           <div class="form-group">
                               <asp:TextBox ID="txtProNom" runat="server" Height="24px" Width="370px"></asp:TextBox>
                           </div>

                       </div>
                         <div class="form-group">
                           <label>Telefono</label>
                           <div class="form-group">
                               <asp:TextBox ID="txtProTel" runat="server" Height="24px" Width="370px"></asp:TextBox>
                               
                           </div>
                                 <asp:Button ID="btnIngresarP" runat="server" Height="28px" Text="Ingresar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF"/>
                                 <asp:Button ID="btnActualizarP" runat="server" Height="28px" Text="Actualizar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF" />
                                 <asp:Button ID="btnEliminarP" runat="server" Height="28px" Text="Eliminar" Width="91px" BackColor="Red" BorderColor="#0066FF"  />
                                 <asp:Button ID="btnBuscarP" runat="server" Height="28px" Text="Buscar" Width="91px" BackColor="#66CCFF" BorderColor="#0066FF"/>


                       </div>
                   </div>
               </div>
           </div>

       </div>
   </section>
            <section class="content">
       <h2>Alumnos</h2>
       <div class="row">
           <div class="col-md-6">
               <div class="box-primary">
                   <div class="box-body">
                       <div class="form-group">
                           <label>Documento</label>
                           <div class="form-group">
                               <asp:TextBox ID="TextBox4" runat="server" Height="24px" Width="370px"></asp:TextBox>
                           </div>

                       </div>
                        <div class="form-group">
                           <label>Apellido</label>
                           <div class="form-group">
                               <asp:TextBox ID="TextBox5" runat="server" Height="24px" Width="370px"></asp:TextBox>
                           </div>

                       </div>
                         <div class="form-group">
                           <label>Telefono</label>
                           <div class="form-group">
                               <asp:TextBox ID="TextBox6" runat="server" Height="24px" Width="370px"></asp:TextBox>
                               
                           </div>
                                 <asp:Button ID="btnIngresarALu" runat="server" Height="28px" Text="Ingresar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF"/>
                                 <asp:Button ID="btnAcualizarALu" runat="server" Height="28px" Text="Actualizar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF" />
                                 <asp:Button ID="btnEliminarALu" runat="server" Height="28px" Text="Eliminar" Width="91px" BackColor="Red" BorderColor="#0066FF"  />
                                 <asp:Button ID="btnBuscarALu" runat="server" Height="28px" Text="Buscar" Width="91px" BackColor="#66CCFF" BorderColor="#0066FF"  />


                       </div>
                   </div>
               </div>
           </div>

       </div>
   </section>
              <section class="content">
       <h2>Aulas</h2>
       <div class="row">
           <div class="col-md-6">
               <div class="box-primary">
                   <div class="box-body">
                       <div class="form-group">
                           <label>Numero</label>
                           <div class="form-group">
                               <asp:TextBox ID="TextBox7" runat="server" Height="24px" Width="370px"></asp:TextBox>
                           </div>

                       </div>
                        <div class="form-group">
                           <label>Domicilio</label>
                           <div class="form-group">
                               <asp:TextBox ID="TextBox8" runat="server" Height="24px" Width="370px"></asp:TextBox>
                           </div>

                       </div>
                         <div class="form-group">
                           <label>Telefono</label>
                           <div class="form-group">
                               <asp:TextBox ID="TextBox9" runat="server" Height="24px" Width="370px"></asp:TextBox>
                               
                           </div>
                                 <asp:Button ID="btnIngresarAu" runat="server" Height="28px" Text="Ingresar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF"/>
                                 <asp:Button ID="btnActualizarAu" runat="server" Height="28px" Text="Actualizar" Width="91px" BackColor="#99FF99" BorderColor="#0066FF" />
                                 <asp:Button ID="btnEliminarAu" runat="server" Height="28px" Text="Eliminar" Width="91px" BackColor="Red" BorderColor="#0066FF"  />
                                 <asp:Button ID="btnBuscarAu" runat="server" Height="28px" Text="Buscar" Width="91px" BackColor="#66CCFF" BorderColor="#0066FF"  />


                       </div>
                   </div>
               </div>
           </div>

       </div>
   </section>-->
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
