using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;

public class PrincipalController : Controller
{
public  static string nombre = "";
public  static string dojo = "";
public static string leng = "";
public static string com = "";

[HttpGet]
[Route("")]
public IActionResult Index(){
    return View("Index");
}
//Donde mosttramos la info
[HttpGet]
[Route("Alumnos")]
public IActionResult Alumnos(){
      
    return View("Alumnos");
}

// metodo para volve.<a href="/">Go back</a> es otra opcion
[HttpGet]
[Route("volver")]
public RedirectToActionResult Volver(){
      
    return RedirectToAction("Index");
}

//metodo post donde en base a la clase Survey, 
//creamos un objeto yoursurvey que toma los datos desde post del html
[HttpPost("survey")]
public IActionResult Submission(Survey yourSurvey)
{

 // hacia donde retornamos una vez los datos son enviados
    return View("Alumnos",yourSurvey);
}





}