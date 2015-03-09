using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SGTE_V1._8.Models;

namespace SGTE_V1._8.Controllers
{
    public class FuncionarioTesteController : Controller
    {
        private SGTE2Entities db = new SGTE2Entities();

        // GET: FuncionarioTeste
        public ActionResult Index()
        {
            return View(db.Tbl_Funcionario.ToList());
        }

        // GET: FuncionarioTeste/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Funcionario tbl_Funcionario = db.Tbl_Funcionario.Find(id);
            if (tbl_Funcionario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Funcionario);
        }

        // GET: FuncionarioTeste/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuncionarioTeste/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Funcao,Matricula,Nome,Endereco,Bairro,Cidade,CEP,Estado,Tel_Residencial,Tel_Celular,Email,RG,CPF,Data_Nasc,Sexo,Ativo")] Tbl_Funcionario tbl_Funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Funcionario.Add(tbl_Funcionario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Funcionario);
        }

        // GET: FuncionarioTeste/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Funcionario tbl_Funcionario = db.Tbl_Funcionario.Find(id);
            if (tbl_Funcionario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Funcionario);
        }

        // POST: FuncionarioTeste/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Funcao,Matricula,Nome,Endereco,Bairro,Cidade,CEP,Estado,Tel_Residencial,Tel_Celular,Email,RG,CPF,Data_Nasc,Sexo,Ativo")] Tbl_Funcionario tbl_Funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Funcionario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Funcionario);
        }

        // GET: FuncionarioTeste/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Funcionario tbl_Funcionario = db.Tbl_Funcionario.Find(id);
            if (tbl_Funcionario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Funcionario);
        }

        // POST: FuncionarioTeste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Funcionario tbl_Funcionario = db.Tbl_Funcionario.Find(id);
            db.Tbl_Funcionario.Remove(tbl_Funcionario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
