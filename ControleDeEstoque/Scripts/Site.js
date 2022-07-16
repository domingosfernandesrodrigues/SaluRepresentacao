$('.date input').mask("99/99/9999");
$('#Cpf').mask("999.999.999-99");
$('.Cnpj').mask("99.999.999/9999-99");
$('.NumeroProcesso').mask("9999.99999-99/9999");
$('#Cep').mask("99999-999");
$('.fone').mask("(99) 9999-9999");
$('.money').priceFormat({
    prefix: 'R$ ',
    centsSeparator: ',',
    thousandsSeparator: '.',
    clearPrefix: true
});

$('.btn').tooltip();

$('.date input').datepicker({
    format: 'dd/mm/yyyy',
    language: 'pt-BR',
    autoclose: true,
    todayHighlight: true
});

// Atribuir classe para bom funcionamento do bootstrap 
$(":text").addClass("form-control");
$("input[type=number]").addClass("form-control");
$("select").addClass("form-control");
$(":password").addClass("form-control");
$("textarea").addClass("form-control");
// ------------------ SPIN (Loading...) ------------------
var opts = {
    lines: 15, // The number of lines to draw
    length: 20, // The length of each line
    width: 10, // The line thickness
    radius: 30, // The radius of the inner circle
    corners: 1, // Corner roundness (0..1)
    rotate: 0, // The rotation offset
    direction: 1, // 1: clockwise, -1: counterclockwise
    color: '#000', // #rgb or #rrggbb or array of colors
    speed: 1, // Rounds per second
    trail: 60, // Afterglow percentage
    shadow: true, // Whether to render a shadow
    hwaccel: false, // Whether to use hardware acceleration
    className: 'spinner', // The CSS class to assign to the spinner
    zIndex: 2e9, // The z-index (defaults to 2000000000)
    top: '50%', // Top position relative to parent in px
    left: '50%' // Left position relative to parent in px
};

var spinner = new Spinner(opts);
var target = document.getElementsByTagName('body')[0];

$(".spinner").on("click", function () {
    spinner.spin(target);
});

function ParaSpinner() {
    spinner.stop(target);
}

//================ Usar com Data Table ============================================================
function TblDataTaable(col) {
    $('.tblDataTable').dataTable({
        "bFilter": true,
        "bSortCellsTop": true,
        "pagingType": "simple_numbers",
        "iDisplayLength": 100,
        "bLengthChange": false,
        "autoWidth": false,
        "aoColumnDefs": [{ "bSortable": false, "aTargets": [col] }],
        "oLanguage": {
            "sLengthMenu": "Mostrar  _MENU_  registros",
            "sZeroRecords": "Não foram encontrados resultados",
            "sInfo": "Página _PAGE_ de _PAGES_ (Total de Registros: _MAX_)",
            "sInfoEmpty": "Mostrando de 0 até 0 de 0 registros",
            "sInfoFiltered": "(encontrado _TOTAL_ regist  ro(s))",
            "sInfoPostFix": "",
            "oPaginate": {
                "sPrevious": "Anterior",
                "sNext": "Seguinte",
            }
        }
    });
};
//================ Usar com Data Table ============================================================