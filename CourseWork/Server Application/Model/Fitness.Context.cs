﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server_Application.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FitnessCenterDBEntities : DbContext
    {
        public FitnessCenterDBEntities()
            : base("name=FitnessCenterDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aboniments> Aboniments { get; set; }
        public virtual DbSet<AbonimentsWithClient> AbonimentsWithClient { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfo { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<GroupLessons> GroupLessons { get; set; }
        public virtual DbSet<IndividualLesson> IndividualLesson { get; set; }
        public virtual DbSet<LessonsType> LessonsType { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<SportHalls> SportHalls { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TrainerInfo> TrainerInfo { get; set; }
        public virtual DbSet<WorkTimes> WorkTimes { get; set; }
    
        public virtual int AddAboniment(string name, string description, Nullable<int> duration, Nullable<bool> poolacsess, Nullable<decimal> cost, Nullable<double> sale, Nullable<int> groupCount)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("Duration", duration) :
                new ObjectParameter("Duration", typeof(int));
    
            var poolacsessParameter = poolacsess.HasValue ?
                new ObjectParameter("poolacsess", poolacsess) :
                new ObjectParameter("poolacsess", typeof(bool));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("Cost", cost) :
                new ObjectParameter("Cost", typeof(decimal));
    
            var saleParameter = sale.HasValue ?
                new ObjectParameter("Sale", sale) :
                new ObjectParameter("Sale", typeof(double));
    
            var groupCountParameter = groupCount.HasValue ?
                new ObjectParameter("groupCount", groupCount) :
                new ObjectParameter("groupCount", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddAboniment", nameParameter, descriptionParameter, durationParameter, poolacsessParameter, costParameter, saleParameter, groupCountParameter);
        }
    
        public virtual int AddClient(string name, string lastName, string email, string pass)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddClient", nameParameter, lastNameParameter, emailParameter, passParameter);
        }
    
        public virtual int AddCustomerInfo(Nullable<int> clientid, string city, Nullable<bool> sex, string adress, Nullable<System.DateTime> bdate, string phone, string userimage, string detailinfo)
        {
            var clientidParameter = clientid.HasValue ?
                new ObjectParameter("clientid", clientid) :
                new ObjectParameter("clientid", typeof(int));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var sexParameter = sex.HasValue ?
                new ObjectParameter("sex", sex) :
                new ObjectParameter("sex", typeof(bool));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            var bdateParameter = bdate.HasValue ?
                new ObjectParameter("bdate", bdate) :
                new ObjectParameter("bdate", typeof(System.DateTime));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var userimageParameter = userimage != null ?
                new ObjectParameter("userimage", userimage) :
                new ObjectParameter("userimage", typeof(string));
    
            var detailinfoParameter = detailinfo != null ?
                new ObjectParameter("detailinfo", detailinfo) :
                new ObjectParameter("detailinfo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddCustomerInfo", clientidParameter, cityParameter, sexParameter, adressParameter, bdateParameter, phoneParameter, userimageParameter, detailinfoParameter);
        }
    
        public virtual int AddEmployee(string name, string lastName, string empEmail, Nullable<System.DateTime> empBdate, string empPhone, Nullable<int> postid, Nullable<System.DateTime> empdate, Nullable<bool> gender)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var empEmailParameter = empEmail != null ?
                new ObjectParameter("empEmail", empEmail) :
                new ObjectParameter("empEmail", typeof(string));
    
            var empBdateParameter = empBdate.HasValue ?
                new ObjectParameter("empBdate", empBdate) :
                new ObjectParameter("empBdate", typeof(System.DateTime));
    
            var empPhoneParameter = empPhone != null ?
                new ObjectParameter("empPhone", empPhone) :
                new ObjectParameter("empPhone", typeof(string));
    
            var postidParameter = postid.HasValue ?
                new ObjectParameter("postid", postid) :
                new ObjectParameter("postid", typeof(int));
    
            var empdateParameter = empdate.HasValue ?
                new ObjectParameter("empdate", empdate) :
                new ObjectParameter("empdate", typeof(System.DateTime));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddEmployee", nameParameter, lastNameParameter, empEmailParameter, empBdateParameter, empPhoneParameter, postidParameter, empdateParameter, genderParameter);
        }
    
        public virtual int AddGrouplesson(Nullable<int> trainerId, Nullable<int> lessontypeId, Nullable<int> hallId, Nullable<System.DateTime> lessdate, Nullable<int> lesstimeId)
        {
            var trainerIdParameter = trainerId.HasValue ?
                new ObjectParameter("TrainerId", trainerId) :
                new ObjectParameter("TrainerId", typeof(int));
    
            var lessontypeIdParameter = lessontypeId.HasValue ?
                new ObjectParameter("lessontypeId", lessontypeId) :
                new ObjectParameter("lessontypeId", typeof(int));
    
            var hallIdParameter = hallId.HasValue ?
                new ObjectParameter("hallId", hallId) :
                new ObjectParameter("hallId", typeof(int));
    
            var lessdateParameter = lessdate.HasValue ?
                new ObjectParameter("lessdate", lessdate) :
                new ObjectParameter("lessdate", typeof(System.DateTime));
    
            var lesstimeIdParameter = lesstimeId.HasValue ?
                new ObjectParameter("lesstimeId", lesstimeId) :
                new ObjectParameter("lesstimeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddGrouplesson", trainerIdParameter, lessontypeIdParameter, hallIdParameter, lessdateParameter, lesstimeIdParameter);
        }
    
        public virtual int AddIndividualLess(Nullable<int> trainerId, Nullable<int> lessontypeId, Nullable<int> hallId, Nullable<System.DateTime> lessdate, Nullable<int> lesstimeId, Nullable<int> clientid)
        {
            var trainerIdParameter = trainerId.HasValue ?
                new ObjectParameter("TrainerId", trainerId) :
                new ObjectParameter("TrainerId", typeof(int));
    
            var lessontypeIdParameter = lessontypeId.HasValue ?
                new ObjectParameter("lessontypeId", lessontypeId) :
                new ObjectParameter("lessontypeId", typeof(int));
    
            var hallIdParameter = hallId.HasValue ?
                new ObjectParameter("hallId", hallId) :
                new ObjectParameter("hallId", typeof(int));
    
            var lessdateParameter = lessdate.HasValue ?
                new ObjectParameter("lessdate", lessdate) :
                new ObjectParameter("lessdate", typeof(System.DateTime));
    
            var lesstimeIdParameter = lesstimeId.HasValue ?
                new ObjectParameter("lesstimeId", lesstimeId) :
                new ObjectParameter("lesstimeId", typeof(int));
    
            var clientidParameter = clientid.HasValue ?
                new ObjectParameter("clientid", clientid) :
                new ObjectParameter("clientid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddIndividualLess", trainerIdParameter, lessontypeIdParameter, hallIdParameter, lessdateParameter, lesstimeIdParameter, clientidParameter);
        }
    
        public virtual int AddPost(string postName, string postDescription, Nullable<decimal> postsalary)
        {
            var postNameParameter = postName != null ?
                new ObjectParameter("postName", postName) :
                new ObjectParameter("postName", typeof(string));
    
            var postDescriptionParameter = postDescription != null ?
                new ObjectParameter("postDescription", postDescription) :
                new ObjectParameter("postDescription", typeof(string));
    
            var postsalaryParameter = postsalary.HasValue ?
                new ObjectParameter("postsalary", postsalary) :
                new ObjectParameter("postsalary", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPost", postNameParameter, postDescriptionParameter, postsalaryParameter);
        }
    
        public virtual int AddTrainerAbout(Nullable<int> empId, string about, string photo)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("empId", empId) :
                new ObjectParameter("empId", typeof(int));
    
            var aboutParameter = about != null ?
                new ObjectParameter("about", about) :
                new ObjectParameter("about", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddTrainerAbout", empIdParameter, aboutParameter, photoParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CashinAbon(Nullable<System.DateTime> from, Nullable<System.DateTime> end)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CashinAbon", fromParameter, endParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CashinGroup(Nullable<System.DateTime> from, Nullable<System.DateTime> end)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CashinGroup", fromParameter, endParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CashInIndiv(Nullable<System.DateTime> from, Nullable<System.DateTime> end)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CashInIndiv", fromParameter, endParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> CashOutSalary(Nullable<System.DateTime> from, Nullable<System.DateTime> end)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("CashOutSalary", fromParameter, endParameter);
        }
    
        public virtual int ChangeAboniment(Nullable<int> id, string name, string description, Nullable<int> duration, Nullable<bool> poolacsess, Nullable<decimal> cost, Nullable<double> sale, Nullable<int> groupCount)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("Duration", duration) :
                new ObjectParameter("Duration", typeof(int));
    
            var poolacsessParameter = poolacsess.HasValue ?
                new ObjectParameter("poolacsess", poolacsess) :
                new ObjectParameter("poolacsess", typeof(bool));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("Cost", cost) :
                new ObjectParameter("Cost", typeof(decimal));
    
            var saleParameter = sale.HasValue ?
                new ObjectParameter("Sale", sale) :
                new ObjectParameter("Sale", typeof(double));
    
            var groupCountParameter = groupCount.HasValue ?
                new ObjectParameter("groupCount", groupCount) :
                new ObjectParameter("groupCount", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangeAboniment", idParameter, nameParameter, descriptionParameter, durationParameter, poolacsessParameter, costParameter, saleParameter, groupCountParameter);
        }
    
        public virtual int ChangeEmp(Nullable<int> empId, string name, string lastName, string empEmail, Nullable<System.DateTime> empBdate, string empPhone, Nullable<int> postid, Nullable<bool> gender)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("empId", empId) :
                new ObjectParameter("empId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var empEmailParameter = empEmail != null ?
                new ObjectParameter("empEmail", empEmail) :
                new ObjectParameter("empEmail", typeof(string));
    
            var empBdateParameter = empBdate.HasValue ?
                new ObjectParameter("empBdate", empBdate) :
                new ObjectParameter("empBdate", typeof(System.DateTime));
    
            var empPhoneParameter = empPhone != null ?
                new ObjectParameter("empPhone", empPhone) :
                new ObjectParameter("empPhone", typeof(string));
    
            var postidParameter = postid.HasValue ?
                new ObjectParameter("postid", postid) :
                new ObjectParameter("postid", typeof(int));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangeEmp", empIdParameter, nameParameter, lastNameParameter, empEmailParameter, empBdateParameter, empPhoneParameter, postidParameter, genderParameter);
        }
    
        public virtual int ChangePassWord(Nullable<int> id, string pass)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangePassWord", idParameter, passParameter);
        }
    
        public virtual int ChangePost(Nullable<int> id, string postName, string postDescription, Nullable<decimal> postsalary)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var postNameParameter = postName != null ?
                new ObjectParameter("postName", postName) :
                new ObjectParameter("postName", typeof(string));
    
            var postDescriptionParameter = postDescription != null ?
                new ObjectParameter("postDescription", postDescription) :
                new ObjectParameter("postDescription", typeof(string));
    
            var postsalaryParameter = postsalary.HasValue ?
                new ObjectParameter("postsalary", postsalary) :
                new ObjectParameter("postsalary", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangePost", idParameter, postNameParameter, postDescriptionParameter, postsalaryParameter);
        }
    
        public virtual int DeleteAboniment(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteAboniment", idParameter);
        }
    
        public virtual int DeleteEmployee(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteEmployee", idParameter);
        }
    
        public virtual int DeletePost(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePost", idParameter);
        }
    
        public virtual ObjectResult<GETClientsByName_Result> GETClientsByName(string name, string lastName)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETClientsByName_Result>("GETClientsByName", nameParameter, lastNameParameter);
        }
    
        public virtual ObjectResult<GetShedule_Result> GetShedule(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetShedule_Result>("GetShedule", dateParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int TOGroupLesson(Nullable<int> clientid, Nullable<int> groupLessonid)
        {
            var clientidParameter = clientid.HasValue ?
                new ObjectParameter("clientid", clientid) :
                new ObjectParameter("clientid", typeof(int));
    
            var groupLessonidParameter = groupLessonid.HasValue ?
                new ObjectParameter("groupLessonid", groupLessonid) :
                new ObjectParameter("groupLessonid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TOGroupLesson", clientidParameter, groupLessonidParameter);
        }
    
        public virtual ObjectResult<TrainerList_Result> TrainerList(Nullable<int> lessonId)
        {
            var lessonIdParameter = lessonId.HasValue ?
                new ObjectParameter("lessonId", lessonId) :
                new ObjectParameter("lessonId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TrainerList_Result>("TrainerList", lessonIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> WoorkTimGroup(Nullable<System.DateTime> data, Nullable<int> hallid)
        {
            var dataParameter = data.HasValue ?
                new ObjectParameter("data", data) :
                new ObjectParameter("data", typeof(System.DateTime));
    
            var hallidParameter = hallid.HasValue ?
                new ObjectParameter("hallid", hallid) :
                new ObjectParameter("hallid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("WoorkTimGroup", dataParameter, hallidParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> WoorkTimIndiv(Nullable<System.DateTime> data, Nullable<int> hallid)
        {
            var dataParameter = data.HasValue ?
                new ObjectParameter("data", data) :
                new ObjectParameter("data", typeof(System.DateTime));
    
            var hallidParameter = hallid.HasValue ?
                new ObjectParameter("hallid", hallid) :
                new ObjectParameter("hallid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("WoorkTimIndiv", dataParameter, hallidParameter);
        }
    }
}
