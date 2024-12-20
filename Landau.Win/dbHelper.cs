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
        private static dbEntities db = new dbEntities();

        #region Definitions
        public static List<costumerTBL> allCostumers;
        public static List<orderTBL> allOrders;
        public static List<subOrderTBL> allSubOrders;
        public static List<serviceTBL> allServices;
        #endregion

        #region load func
        public static void init()
        {
            getAllCostumers();
            getAllOrders();
        }

        #endregion

        #region get func
        public static costumerTBL getCostumerByName(string fn, string ln)
        {
            costumerTBL result = allCostumers.Where(x => x.firstName == fn
                                                       && x.lastName == ln)
                                             .FirstOrDefault();
            return result;
        }

        public static List<costumerTBL> getAllCostumers()
        {
            allCostumers = (from s in db.costumerTBL orderby s.firstName select s).ToList();
            return allCostumers;
        }
        public static List<orderTBL> getAllOrders() 
        {
            allOrders = (from s in db.orderTBL select s).ToList(); 
            return allOrders;
        }
        public static List<subOrderTBL> getAllSubOrders()
        {
            allCostumers = (from s in db.costumerTBL orderby s.firstName select s).ToList();
            return allSubOrders;
        }
        public static List<serviceTBL> getAllServices()
        {
            allCostumers = (from s in db.costumerTBL orderby s.firstName select s).ToList();
            return allServices;
        }

        #endregion

        #region add func
        public static costumerTBL addCostumer(costumerTBL c1)
        {
            try
            {
                db.costumerTBL.Add(c1);
                db.SaveChanges();
                getAllCostumers();
                return c1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add costumer " + ex.Message.ToString());
                return null;
            }
        }

        public static orderTBL addOrder(orderTBL p1) 
        {
            try
            {
                db.orderTBL.Add(p1); 
                db.SaveChanges();
                getAllOrders(); 
                return p1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add order " + ex.Message.ToString()); 
                return null;
            }
        }

        #endregion

        #region update func
        public static bool updateCostumer(costumerTBL c1)
        {
            costumerTBL toUpdate = (from s in db.costumerTBL where s.Id == c1.Id select s).FirstOrDefault();
            if (toUpdate != null)
            {
                toUpdate.Id = c1.Id;
                toUpdate.firstName = c1.firstName;
                toUpdate.lastName = c1.lastName;
                toUpdate.email = c1.email;
                toUpdate.phoneNumber = c1.phoneNumber;
                db.SaveChanges();
                getAllCostumers();
                return true;
            }
            return false;
        }

        public static bool updateOrder(orderTBL p1) 
        {
            orderTBL toUpdate = (from s in db.orderTBL where s.Id == p1.Id select s).FirstOrDefault(); // Replaced phoneTBL with orderTBL
            if (toUpdate != null)
            {
                toUpdate.Id = p1.Id;
                toUpdate.coustumerID = p1.coustumerID;
                toUpdate.address = p1.address;
                toUpdate.date = p1.date;
                toUpdate.notes = p1.notes;
                db.SaveChanges();
                getAllOrders(); 
                return true;
            }
            return false;
        }

        #endregion

        #region delete func
        public static bool deleteCostumer(costumerTBL c1)
        {
            try
            {
                costumerTBL toDelete = (from s in db.costumerTBL where s.Id == c1.Id select s).FirstOrDefault();
                if (toDelete == null)
                    return false;
                db.costumerTBL.Remove(toDelete);
                db.SaveChanges();
                getAllCostumers();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete: " + ex.Message.ToString());
                return false;
            }
        }

        public static bool deleteOrder(orderTBL p1) 
        {
            try
            {
                orderTBL toDelete = (from s in db.orderTBL where s.Id == p1.Id select s).FirstOrDefault(); // Replaced phoneTBL with orderTBL
                if (toDelete == null)
                    return false;
                db.orderTBL.Remove(toDelete); 
                db.SaveChanges();
                getAllOrders(); // 
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete: " + ex.Message.ToString());
                return false;
            }
        }
        #endregion
    }
}