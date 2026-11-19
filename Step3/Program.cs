using Step3.Controllers;
using Step3.Interfaces;
using Step3.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); 

builder.Services.AddControllers();



//IEmployeeService service;

//public EmployeeController(IEmployeeService _service)
//{  //_service  (instance of the EmployeeService) 

//    service = new EmployeeService();// Problem of this code... 
//                                    //1.problem of code  

//    //what if i am goign the assign this work to the asp.ent core so then i can reduce my headache
//    //2. i want to assign this work new EmployeeService() to the asp.net core

//}

builder.Services.AddTransient<IEmployeeService , EmployeeService>();
//now asp.ent core taking responsbilty to create the instanc of the EmployeeService


var app = builder.Build();

app.MapControllers();

app.Run();

