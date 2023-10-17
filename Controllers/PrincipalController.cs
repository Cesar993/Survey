
// indicamos que utilizaremos aspnetcore y mvc
using Microsoft.AspNetCore.Mvc;

namespace ProyectoPelis.controller;

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
[HttpGet]
[Route("Alumnos")]
public IActionResult Alumnos(){
   
    ViewBag.nombreNuevo = nombre;
    ViewBag.dojoNuevo = dojo;
    ViewBag.lengNuevo = leng;
    ViewBag.comNuevo = com;
    
    return View("Alumnos");
}



[HttpPost]
[Route("nuevo/alumno")]
public RedirectToActionResult AgregarAlumno(string Nombre, string Dojo,string Lenguage, string Coments){
    nombre =Nombre;
    dojo =Dojo;
    leng =Lenguage;
    com =Coments;
    return RedirectToAction("Alumnos");
}

[HttpGet]
[Route("volver")]
public RedirectToActionResult Volver(string Nombre, string Dojo,string Lenguage, string Coments){
    nombre =Nombre;
    
    return RedirectToAction("Index");
}




}