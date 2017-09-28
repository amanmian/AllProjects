$(function () {  
    $("#jqGrid").jqGrid({  
        url: "/Student/GetStudents",  
        datatype: 'json',  
        mtype: 'Get',  
        colNames: ['ID', 'Name', 'Email', 'Phone', 'Class', 'Admission Date'],  
        colModel: [  
            { key: true, hidden: true, name: 'ID', index: 'ID', editable: true },  
            { key: false, name: 'Name', index: 'Name', editable: true },  
            { key: false, name: 'Email', index: 'Email', editable: true },  
            { key: false, name: 'phone', index: 'phone', editable: true, edittype: 'select', editoptions: { value: { 'M': 'Male', 'F': 'Female', 'N': 'None' } } },  
            { key: false, name: 'ClassName', index: 'ClassName', editable: true, edittype: 'select', editoptions: { value: { '1': '1st Class', '2': '2nd Class', '3': '3rd Class', '4': '4th Class', '5': '5th Class' } } },  
            { key: false, name: 'DateOfAdmission', index: 'DateOfAdmission', editable: true, formatter: 'date', formatoptions: { newformat: 'd/m/Y' } }],  
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
    });  
});  