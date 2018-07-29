using System;

namespace GTMIS.Model
{
    //T_SysModule
    public class T_SysModule
    {

        /// <summary>
        /// FModuleID
        /// </summary>		
        public int FModuleID { get; set; }
        /// <summary>
        /// FModuleName
        /// </summary>		
        public string FModuleName { get; set; }
        /// <summary>
        /// FParent
        /// </summary>		
        public int FParent { get; set; }
        /// <summary>
        /// FIcon
        /// </summary>		
        public string FIcon { get; set; }
        /// <summary>
        /// FURL
        /// </summary>		
        public string FURL { get; set; }
        /// <summary>
        /// FCreateDate
        /// </summary>		
        public DateTime FCreateDate { get; set; }
        /// <summary>
        /// FCreateBy
        /// </summary>		
        public string FCreateBy { get; set; }

    }
}