using System;

namespace GTMIS.Model
{
    //T_SysPremission
    public class T_SysPremission
    {

        /// <summary>
        /// FPremissionID
        /// </summary>		
        public int FPremissionID { get; set; }
        /// <summary>
        /// FModuleID
        /// </summary>		
        public int FModuleID { get; set; }
        /// <summary>
        /// FPremissionName
        /// </summary>		
        public string FPremissionName { get; set; }
        /// <summary>
        /// FCreateBy
        /// </summary>		
        public string FCreateBy { get; set; }
        /// <summary>
        /// FCreateDate
        /// </summary>		
        public DateTime FCreateDate { get; set; }

    }
}