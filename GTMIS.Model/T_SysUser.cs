using System;

namespace GTMIS.Model
{
    //T_SysUser
    public class T_SysUser
    {

        /// <summary>
        /// FUserID
        /// </summary>		
        public int FUserID { get; set; }
        /// <summary>
        /// FUserName
        /// </summary>		
        public string FUserName { get; set; }
        /// <summary>
        /// FPassword
        /// </summary>		
        public string FPassword { get; set; }
        /// <summary>
        /// FRoleID
        /// </summary>		
        public int FRoleID { get; set; }
        /// <summary>
        /// FDeptID
        /// </summary>		
        public int FDeptID { get; set; }
        /// <summary>
        /// CreateBy
        /// </summary>		
        public string CreateBy { get; set; }
        /// <summary>
        /// CreateDate
        /// </summary>		
        public DateTime CreateDate { get; set; }

    }
}