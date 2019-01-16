using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PedidosWeb.Models;

namespace PedidosWeb.Controllers
{
    public class CategoriaController : Controller
    {
        private Categoria FindCategoria(int id)
        {
            Categoria categoria = new Categoria();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["categoriaConnection"].ConnectionString))
            {
                categoria = db.Query<Categoria>(
                    "SELECT c.id, c.nome " +
                    "FROM   loja.dbo.categoria c " +
                    "WHERE  c.id = @Id", new { id }).SingleOrDefault();
            }

            return categoria;
        }
        
        // GET: Categoria
        [HttpGet]
        public ActionResult Index()
        {
            List<Categoria> categoriaList = new List<Categoria>();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["categoriaConnection"].ConnectionString))
            {
                categoriaList = db.Query<Categoria>(
                    "SELECT c.id, c.nome " +
                    "FROM   loja.dbo.categoria c").ToList();
            }

            return View(categoriaList);
        }


        // GET: Categoria/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            Categoria categoria = new Categoria();
            categoria = FindCategoria(id);

            return View(categoria);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {

            Categoria categoriaAux = FindCategoria(categoria.Id);
            if (categoriaAux == null)
            {

                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["categoriaConnection"].ConnectionString))
                {
                    string sqlQuery =
                        "INSERT INTO loja.dbo.categoria(" +
                        "id," +
                        "nome)" +
                        "VALUES(" +
                        categoria.Id + "," +
                        " ' " + categoria.Nome + " ')";

                    int rowsAffected = db.Execute(sqlQuery);
                }

                return RedirectToAction("Index");
            } else
            {
                return RedirectToAction("Details", new {id = categoria.Id});
            }           

        }

        // GET: Categoria/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Categoria categoria = new Categoria();
            categoria = FindCategoria(id);

            return View(categoria);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["categoriaConnection"].ConnectionString))
            {
                string sqlQuery =
                    "UPDATE loja.dbo.categoria " +
                    "SET    nome = ' " + categoria.Nome + " ' " +
                    "WHERE  id = " + categoria.Id;

                int rowsAffected = db.Execute(sqlQuery);
            }
            return RedirectToAction("Index");
        }

        // GET: Categoria/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Categoria categoria = new Categoria();
            categoria = FindCategoria(id);

            return View(categoria);
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["categoriaConnection"].ConnectionString))
            {
                string sqlQuery =
                    "DELETE " +
                    "FROM   loja.dbo.categoria " +
                    "WHERE  id = " + id;

                int rowsAffected = db.Execute(sqlQuery);
            }
            return RedirectToAction("Index");
        }
    }
}
