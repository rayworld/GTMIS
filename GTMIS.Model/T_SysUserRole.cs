using System;

namespace GTMIS.Model
{
    //T_SysUserRole
    public class T_SysUserRole
    {

        /// <summary>
        /// FUserRoleID
        /// </summary>		
        public int FUserRoleID { get; set; }
        /// <summary>
        /// FUserID
        /// </summary>		
        public int FUserID { get; set; }
        /// <summary>
        /// FRoleID
        /// </summary>		
        public int FRoleID { get; set; }
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