/*$(function () {
    $("#jqGrid").jqGrid({
        url: "/Home/GetStudents",
        datatype: 'json',
        mtype: 'Get',
        colNames: ['ID', 'First Name', 'Last Name', 'Standard', 'Group','Course','Age','Area','Street','City','ZipCode'],
        colModel: [
            { key: true, hidden: true, name: 'Stud_id', index: 'Stud_id', editable: true },
            { key: false, name: 'Stud_fname', index: 'Stud_fname', editable: true },
            { key: false, name: 'Stud_lname', index: 'Stud_lname', editable: true },
            { key: false, name: 'Stud_std', index: 'Stud_std', editable: true },
            { key: false, name: 'Stud_group', index: 'Stud_group', editable: true },
            { key: false, name: 'Stud_cousre', index: 'Stud_cousre', editable: true },
            { key: false, name: 'age', index: 'age', editable: true },
            { key: false, name: 'Stud_area', index: 'Stud_area', editable: true },
            { key: false, name: 'Stud_street', index: 'Stud_street', editable: true },
            { key: false, name: 'Stud_city', index: 'Stud_city', editable: true },
            { key: false, name: 'Stud_zipcode', index: 'Stud_zipcode', editable: true },
        ],
        pager: jQuery('#jqControls'),
        rowNum: 10,
        rowList: [10, 20, 30, 40, 50],
        height: '100%',
        viewrecords: true,
        caption: 'Students Records',
        emptyrecords: 'No Students Records are Available to Display',
        jsonReader: {
            root: "rows",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: false,
            Id: "0"
        },
        autowidth: true,
        multiselect: false
    }).navGrid('#jqControls', { edit: true, add: true, del: true, search: false, refresh: true },
        {
            zIndex: 100,
            url: '/Home/Edit',
            closeOnEscape: true,
            closeAfterEdit: true,
            recreateForm: true,
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        },
        {
            zIndex: 100,
            url: "/Home/Create",
            closeOnEscape: true,
            closeAfterAdd: true,
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        },
        {
            zIndex: 100,
            url: "/Home/Delete",
            closeOnEscape: true,
            closeAfterDelete: true,
            recreateForm: true,
            msg: "Are you sure you want to delete Student... ? ",
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        });
});*/

    $(document).ready(function () {  
        //function will be called on button click having id btnsave
        $("#btnSave").click(function () {  
            $.ajax(  
            {  
                type: "POST", //HTTP POST Method  
                url: "StudentWebApi/AddStudent", // Controller/View   
                data: { //Passing data
                   
                    Stud_fname: $("#txtfname").val(),//Reading text box values using Jquery   
                    Stud_lname: $("#txtlname").val(),
                    Stud_std: $("#txtstd").val(),
                    Stud_group: $("#txtgroup").val(),
                    Stud_cousre: $("#txtcourse").val(),
                    Age: $("#txtage").val(),
                    Stud_area: $("#txtarea").val(),
                    Stud_street: $("#txtstreet").val(),
                    Stud_city: $("#txtcity").val(),
                    Stud_zipcode: $("#txtzipcode").val()
                }

  
            });

  
        });  
    });  
  