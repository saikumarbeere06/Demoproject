@model MVCFirstProject.Models.Employee

@{
    ViewBag.Title = "EmployeeInfo";
    Layout = "~/Views/Shared/_Layout.cshtml";
}
<style>

    table{
        font-family:Arial,sans-serif;
        border-collapse:collapse;
        width:100%;
    }
    td,th{
        border:1px solid#dddddd;
        text-align:left;
        padding:8px;
    }
</style>

<h3>EmployeeInformation</h3>
<table>
    <tr>
        <th>EmployeeId</th>
        <th>EmployeeName</th>
        <th>EmployeeLocation</th>
    </tr>

    <tr>
        <td>@Model.EmployeeId</td>
        <td>@Model.EmployeeName</td>
        <td>@Model.EmployeeLocation</td>
    </tr>
</table>

