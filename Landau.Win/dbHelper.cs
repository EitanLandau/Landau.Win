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
        public static List<orderTBL> allOrders; // Replaced phone with order
        #endregion

        #region load func
        public static void init()
        {
            getAllCostumers();
            getAllOrders(); // Replaced getAllPhones with getAllOrders
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

        public static List<orderTBL> getAllOrders() // Replaced getAllPhones with getAllOrders
        {
            allOrders = (from s in db.orderTBL select s).ToList(); // Replaced phoneTBL with orderTBL
            return allOrders;
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

        public static orderTBL addOrder(orderTBL p1) // Replaced addPhone with addOrder
        {
            try
            {
                db.orderTBL.Add(p1); // Replaced phoneTBL with orderTBL
                db.SaveChanges();
                getAllOrders(); // Replaced getAllPhones with getAllOrders
                return p1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add order " + ex.Message.ToString()); // Replaced phone with order
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
                toUpdate.firstName = c1.firstName;
                toUpdate.lastName = c1.lastName;
                db.SaveChanges();
                getAllCostumers();
                return true;
            }
            return false;
        }

        public static bool updateOrder(orderTBL p1) // Replaced updatePhone with updateOrder
        {
            orderTBL toUpdate = (from s in db.orderTBL where s.Id == p1.Id select s).FirstOrDefault(); // Replaced phoneTBL with orderTBL
            if (toUpdate != null)
            {
                toUpdate.Id = p1.Id;
                toUpdate.address = p1.address;// This might still be the order phone, if it refers to a phone in the order.
                db.SaveChanges();
                getAllOrders(); // Replaced getAllPhones with getAllOrders
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

        public static bool deleteOrder(orderTBL p1) // Replaced deletePhone with deleteOrder
        {
            try
            {
                orderTBL toDelete = (from s in db.orderTBL where s.Id == p1.Id select s).FirstOrDefault(); // Replaced phoneTBL with orderTBL
                if (toDelete == null)
                    return false;
                db.orderTBL.Remove(toDelete); // Replaced phoneTBL with orderTBL
                db.SaveChanges();
                getAllOrders(); // Replaced getAllPhones with getAllOrders
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