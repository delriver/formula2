$(document).ready(function () {
    loadDriversTable();
})

function loadDriversTable() {
    dataTable = $('#driversTable').DataTable({
        "ajax": { url: "/Driver/GetAll" },
        "columns": [
            { data: 'name', width: "25%" },
        ]
    });
}