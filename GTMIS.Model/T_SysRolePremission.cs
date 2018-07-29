using System;

namespace GTMIS.Model
{
    //T_SysRolePremission
    public class T_SysRolePremission
    {

        /// <summary>
        /// FRolePremissionID
        /// </summary>		
        public int FRolePremissionID { get; set; }
        /// <summary>
        /// FRoleID
        /// </summary>		
        public int FRoleID { get; set; }
        /// <summary>
        /// FPremissionID
        /// </summary>		
        public int FPremissionID { get; set; }
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