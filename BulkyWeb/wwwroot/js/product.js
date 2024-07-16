
var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/product/getall'
        },
        "columns": [
            { data: 'title', "width": "25%" },
            { data: 'isbn', "width": "15%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'author', "width": "15%" }, 
            { data: 'category.name', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group role=group">
                    <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i>Edit</a>
                    <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2"><i class="bi bi-trash-fill"></i>Delete</a>
                    </div>`
                },
                "width": "25%"}
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    // Assuming 'data' contains the response from the server
                    if (data.success) { // Adjust based on your server response structure
                        dataTable.ajax.reload(); // Reload DataTable
                        toastr.success(data.message); // Show success message
                    } else {
                        toastr.error(data.message); // Show error message if deletion fails
                    }
                },
                error: function (xhr, status, error) {
                    // Handle error case
                    console.error("Error deleting:", error);
                    toastr.error("An error occurred while deleting the item.");
                }
            });
        }
    });
}
