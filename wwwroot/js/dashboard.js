$(document).ready(function () {
	var markup = '<div class="col-6"> <div class="row"><div class="col-4"><img class="profile-pic" src="/img/${profileImage}" /></div><div class="col-6"> <h4 class="emp-name"> ${ firstName } ${ lastName } </h4> <p class="emp-desig"> ${subDepartmentName}</p> 		<P> ${bio}</p> 		</div>	</div ></div > ';

	/* Compile the markup as a named template */
	$.template("employeeTemplate", markup);	
	getEmployees();
	$('#btnSearch').click(() => {
		getEmployees();
    })


});

function getEmployees() {
	let txtSearch = $("#searchKey");		
	let baseurl = "https://localhost:44333/employees/search";
	let url = txtSearch.val() ? baseurl + "?key=" + txtSearch.val() : baseurl;
	$.ajax({		
		url:  url,		
		success: function (data) {
			/* Get the movies array from the data */
			let employees = data;

			/* Remove current set of movie template items */
			$("#employeesList").empty();

			/* Render the template items for each movie
			and insert the template items into the "movieList" */
			$.tmpl("employeeTemplate", employees)
				.appendTo("#employeesList");
		}
	});
}