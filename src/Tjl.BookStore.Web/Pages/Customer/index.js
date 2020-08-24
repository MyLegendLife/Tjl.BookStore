$(function () {
    var dataTable = $('#BookTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        ajax: abp.libs.datatables.createAjax(tjl.bookStore.services.customer.getList),
        columnDefs: [
            { data: "code" },
            { data: "name" },
            { data: "ket" },
            { data: "description" },
            { data: "creationTime" }
        ]
    }));
});