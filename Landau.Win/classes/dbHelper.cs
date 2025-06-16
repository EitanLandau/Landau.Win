using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landau.Win
{
    public class DBHelper
    {
        private static dbEntities db;

        #region Definitions
        public static List<costumerTBL> allCostumers;
        public static List<orderTBL> allOrders;
        public static List<subOrderTBL> allSubOrders;
        public static List<serviceTBL> allServices;
        public static List<lecturesNseminarsTBL> allLecturesNseminars;
        public static List<meetingTBL> allMeetings;
        public static List<projectTBL> allProjects;
        public static List<orderHistoryView> allorderHistoryViews;
        #endregion

        #region Load Functions
        public static void Init()
        {
            db = new dbEntities();
            GetAllCostumers();
            GetAllOrders();
            GetAllSubOrders();
            GetAllServices();
            GetAllLecturesNseminars();
            getOrderHistoryViews();

        }
        public static void getOrderHistoryViews()
        {
            allorderHistoryViews = (from s in db.orderHistoryView select s).ToList();
        }
        #endregion

        #region Get Functions
        public static List<costumerTBL> GetAllCostumers()
        {
            allCostumers = (from c in db.costumerTBL orderby c.lastName select c).ToList();
            return allCostumers;
        }

        public static List<orderTBL> GetAllOrders()
        {
            allOrders = (from o in db.orderTBL orderby o.orderDate select o).ToList();
            return allOrders;
        }

        public static List<subOrderTBL> GetAllSubOrders()
        {
            allSubOrders = (from so in db.subOrderTBL orderby so.date select so).ToList();
            return allSubOrders;
        }

        public static List<serviceTBL> GetAllServices()
        {
            allServices = (from s in db.serviceTBL orderby s.serviceName select s).ToList();
            return allServices;
        }
        public static List<lecturesNseminarsTBL> GetAllLecturesNseminars()
        {
           allLecturesNseminars = (from l in db.lecturesNseminarsTBL orderby l.title select l).ToList();
            return allLecturesNseminars;
        }
        public static List<meetingTBL> GetAllMeetings()
        {
            allMeetings = (from m in db.meetingTBL orderby m.date select m).ToList();
            return allMeetings;
        }
        public static List<projectTBL> GetAllprojects()
        {
            allProjects = (from p in db.projectTBL orderby p.title select p).ToList();
            return allProjects;
        }
        #endregion

        #region Add Functions
        public static costumerTBL AddCostumer(costumerTBL customer)
        {
            try
            {
                db.costumerTBL.Add(customer);
                db.SaveChanges();
                GetAllCostumers();
                return customer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
                return null;
            }
        }

        public static orderTBL AddOrder(orderTBL order)
        {
            try
            {
                db.orderTBL.Add(order);
                db.SaveChanges();
                GetAllOrders();
                return order;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order: " + ex.Message);
                return null;
            }
        }

        public static subOrderTBL AddSubOrder(subOrderTBL subOrder)
        {
            try
            {
                db.subOrderTBL.Add(subOrder);
                db.SaveChanges();
                GetAllSubOrders();
                return subOrder;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding sub-order: " + ex.Message);
                return null;
            }
        }
        public static lecturesNseminarsTBL AddProduct(lecturesNseminarsTBL product)
        {
            try
            {
                db.lecturesNseminarsTBL.Add(product);
                db.SaveChanges();
                GetAllLecturesNseminars();
                return product;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
                return null;
            }
        }
        public static serviceTBL AddService(serviceTBL service)
        {
            try
            {
                db.serviceTBL.Add(service);
                db.SaveChanges();
                GetAllServices();
                return service;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding service: " + ex.Message);
                return null;
            }
        }
            public static meetingTBL AddMeeting(meetingTBL meeting)
            {
                try
                {
                    db.meetingTBL.Add(meeting);
                    db.SaveChanges();
                    GetAllServices();
                    return meeting;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding service: " + ex.Message);
                    return null;
                }
            }
        public static projectTBL AddProject(projectTBL project)
        {
            try
            {
                db.projectTBL.Add(project);
                db.SaveChanges();
                GetAllprojects();
                return project;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding service: " + ex.Message);
                return null;
            }
        }
        #endregion

        #region Update Functions
        public static bool UpdateCostumer(costumerTBL customer)
        {
            var toUpdate = db.costumerTBL.FirstOrDefault(c => c.Id == customer.Id);
            if (toUpdate != null)
            {
                toUpdate.Id = customer.Id;
                toUpdate.firstName = customer.firstName;
                toUpdate.lastName = customer.lastName;
                toUpdate.email = customer.email;
                toUpdate.phoneNumber = customer.phoneNumber;
                toUpdate.bDate = customer.bDate;
                toUpdate.notes = customer.notes;
                db.SaveChanges();
                GetAllCostumers();
                return true;
            }
            return false;
        }

        public static bool UpdateOrder(orderTBL order)
        {
            var toUpdate = db.orderTBL.FirstOrDefault(o => o.Id == order.Id);
            if (toUpdate != null)
            {
                toUpdate.Id = order.Id;
                toUpdate.costumerID = order.costumerID;
                toUpdate.orderDate = order.orderDate;
                toUpdate.status = order.status;
                toUpdate.notes = order.notes;
             
                db.SaveChanges();
                GetAllOrders();
                return true;
            }
            return false;
        }

        public static bool UpdateSubOrder(subOrderTBL subOrder)
        {
            var toUpdate = db.subOrderTBL.FirstOrDefault(so => so.Id == subOrder.Id);
            if (toUpdate != null)
            {
                toUpdate.Id = subOrder.Id;
                toUpdate.lectureID = subOrder.lectureID;
                toUpdate.orderID = subOrder.orderID;
                toUpdate.date = subOrder.date;
                toUpdate.adress = subOrder.adress;
                toUpdate.amountInvited = subOrder.amountInvited;
                toUpdate.notes = subOrder.notes;
                db.SaveChanges();
                GetAllSubOrders();
                getOrderHistoryViews();
                return true;
            }
            return false;
        }

        public static bool UpdateService(serviceTBL service)
        {
            var toUpdate = db.serviceTBL.FirstOrDefault(s => s.Id == service.Id);
            if (toUpdate != null)
            {
                toUpdate.Id = service.Id;
                toUpdate.description = service.description;
                toUpdate.serviceName = service.serviceName;
                toUpdate.sessionsNum = service.sessionsNum;
                toUpdate.price = service.price;
                db.SaveChanges();
                GetAllServices();
                return true;
            }
            return false;
        }
        public static bool Updatemeeting(meetingTBL meeting)
        {
            var toUpdate = db.meetingTBL.FirstOrDefault(m => m.Id == meeting.Id);
            if (toUpdate != null)
            {
                toUpdate.Id = meeting.Id;
                toUpdate.projectID = meeting.projectID;
                toUpdate.topic = meeting.topic;
                toUpdate.duration = meeting.duration;
                toUpdate.date = meeting.date;
                toUpdate.address = meeting.address;
                toUpdate.typeID = meeting.typeID;
                toUpdate.notes = meeting.notes;
                db.SaveChanges();
                GetAllMeetings();
                return true;
            }
            return false;
        }
        public static bool UpdateProject(projectTBL project)
        {
            var toUpdate = db.projectTBL.FirstOrDefault(p => p.Id == project.Id);
            if (toUpdate != null)
            {
                toUpdate.Id = project.Id;
                toUpdate.customerID = project.customerID;
                toUpdate.title = project.title;
                toUpdate.serviceID = project.serviceID;
                toUpdate.inProcess = project.inProcess;
                toUpdate.description = project.description;
                db.SaveChanges();
                GetAllprojects();
                return true;
            }
            return false;
        }
        #endregion

        #region Delete Functions
        public static bool DeleteCostumer(costumerTBL customer)
        {
            try
            {
                var toDelete = db.costumerTBL.FirstOrDefault(c => c.Id == customer.Id);
                if (toDelete == null)
                    return false;
                db.costumerTBL.Remove(toDelete);
                db.SaveChanges();
                GetAllCostumers();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteOrder(orderTBL order)
        {
            try
            {
                var toDelete = db.orderTBL.FirstOrDefault(o => o.Id == order.Id);
                if (toDelete == null)
                    return false;
                db.orderTBL.Remove(toDelete);
                db.SaveChanges();
                GetAllOrders();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting order: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteSubOrder(subOrderTBL subOrder)
        {
            try
            {
                var toDelete = db.subOrderTBL.FirstOrDefault(so => so.Id == subOrder.Id);
                if (toDelete == null)
                    return false;
                db.subOrderTBL.Remove(toDelete);
                db.SaveChanges();
                GetAllSubOrders();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting sub-order: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteService(serviceTBL service)
        {
            try
            {
                var toDelete = db.serviceTBL.FirstOrDefault(s => s.Id == service.Id);
                if (toDelete == null)
                    return false;
                db.serviceTBL.Remove(toDelete);
                db.SaveChanges();
                GetAllServices();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting service: " + ex.Message);
                return false;
            }
        }
        #endregion
    }
}