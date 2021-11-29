<%@ Page Title="ListBox" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listbox_Demo.aspx.cs" Inherits="WebForms_Demo.Listbox_Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <h1 class="display-4 text-center">ListBox</h1>
        <hr />

        <div class="form-row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <div class="jumbotron">
                        <h6>Enter CountryCode</h6>
                        <asp:TextBox ID="txtCountryCode" CssClass="form-control" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCountryCode" runat="server" ErrorMessage="Enter country code" CssClass="text-danger" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtCountryCode" ValidationGroup="AddOrRemove"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cvCountryCode" runat="server" ErrorMessage="Enter only Number" CssClass="text-danger" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtCountryCode" ValidationGroup="AddOrRemove" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator><br />
                        <h6>Enter CountryName</h6>
                        <asp:TextBox ID="txtCountryName" CssClass="form-control" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCountryName" runat="server" ErrorMessage="Enter country Name" CssClass="text-danger" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtCountryName" ValidationGroup="AddOrRemove"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cvCountryName" runat="server" ErrorMessage="Enter only String" CssClass="text-danger" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtCountryName" ValidationGroup="AddOrRemove" Operator="DataTypeCheck" Type="String"></asp:CompareValidator><br />

                        <div class="row">
                            <div class="col-md-1"></div>
                            <div class="col-md-4">
                                <asp:Button ID="btnAdd" CssClass="btn btn-success btn-lg btn-block" runat="server" Text="ADD" OnClick="btnAdd_Click" ValidationGroup="AddOrRemove"></asp:Button><br />
                            </div>
                            <div class="col-md-2"></div>
                            <div class="col-md-4">
                                <asp:Button ID="btnRemove" CssClass="btn btn-danger btn-lg btn-block" runat="server" Text="Remove" OnClick="btnRemove_Click" ValidationGroup="AddOrRemove"></asp:Button><br />
                            </div>
                            <div class="col-md-1"></div>
                        </div>
                        <asp:Label ID="lblResult" CssClass="text-center" runat="server" Font-Bold="True"></asp:Label>
                        <br />
                        <br />

                        <div class="row">
                            <div class="col-md-4">
                                <h6>Country</h6>
                                <asp:ListBox ID="lbCountry" CssClass="form-control" runat="server" ToolTip="Contry" Rows="10" SelectionMode="Multiple"></asp:ListBox>
                                <asp:RequiredFieldValidator ID="rfvCountry" runat="server" ErrorMessage="select any country" CssClass="text-danger" SetFocusOnError="True" Display="Dynamic" ControlToValidate="lbCountry" ValidationGroup="shiftright"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-4 text-center">
                                <br />
                                <asp:Button ID="btnAllShiftRight" CssClass="btn btn-primary" runat="server" Text=">>" Width="50" OnClick="btnAllShiftRight_Click"></asp:Button><br />
                                <br />
                                <asp:Button ID="btnOneShiftRight" CssClass="btn btn-danger" runat="server" Text=">" Width="50"  ValidationGroup="shiftright" OnClick="btnOneShiftRight_Click"></asp:Button><br />
                                <br />
                                <asp:Button ID="btnAllShiftLeft" CssClass="btn btn-warning" runat="server" Text="<<" Width="50" OnClick="btnAllShiftLeft_Click"></asp:Button><br />
                                <br />
                                <asp:Button ID="btnOneShiftLeft" CssClass="btn btn-success" runat="server" Text="<" Width="50" OnClick="btnOneShiftLeft_Click" ValidationGroup="shiftleft"></asp:Button>
                            </div>
                            <div class="col-md-4">
                                <h6>Modified</h6>
                                <asp:ListBox ID="lbModifiedCountry" CssClass="form-control" runat="server" ToolTip="Contry" Rows="10" SelectionMode="Multiple"></asp:ListBox>
                                <asp:RequiredFieldValidator ID="rfvModifiedCountry" runat="server" ErrorMessage="select any country" CssClass="text-danger" SetFocusOnError="True" Display="Dynamic" ControlToValidate="lbModifiedCountry" ValidationGroup="shiftleft"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                </div>
                <div class="col-md-3"></div>
            </div>
        </div>

    </div>
</asp:Content>
