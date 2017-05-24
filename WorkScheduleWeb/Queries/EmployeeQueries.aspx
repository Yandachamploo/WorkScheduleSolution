<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmployeeQueries.aspx.cs" Inherits="Queries_EmployeeQueries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <div class="jumbotron">
        <h1>Employee Queries</h1>
        <p class="lead">
           Project Setup Exercise
        </p>
       
    </div>
   
    <asp:ObjectDataSource ID="EmployeeListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="EmployeeNamesList_Get" TypeName="WorkScheduleSystem.BLL.EmployeeController"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="EmployeeSkillODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SkillsList_Get" TypeName="WorkScheduleSystem.BLL.EmployeeSkillsController">

        <SelectParameters>
            <asp:ControlParameter ControlID="EmployeeList" PropertyName="SelectedValue" Name="employeeID" Type="Int32"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>




    <div>
    select Employee:
    <asp:DropDownList ID="EmployeeList" runat="server" DataSourceID="EmployeeListODS" DataTextField="Name" DataValueField="ID">


        <asp:ListItem Value="0">select employee</asp:ListItem>
    </asp:DropDownList>

    <asp:Button ID="SumbotQuery" runat="server" Text="Fetch" /><br />
    </div>
    <br />

    <div >
    <asp:GridView ID="EmployeeListSkill" runat="server" AutoGenerateColumns="False" DataSourceID="EmployeeSkillODS">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID"></asp:BoundField>
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description"></asp:BoundField>
        </Columns>
    </asp:GridView>
     </div>
   
</asp:Content>

