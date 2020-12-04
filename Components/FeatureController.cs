/*
' Copyright (c) 2020 Christian Matyas
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace Lifbi.Dnn.UserProfileLifbi.Dnn.UserProfile.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Lifbi.Dnn.UserProfile
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Lifbi.Dnn.UserProfileInfo> colLifbi.Dnn.UserProfiles = GetLifbi.Dnn.UserProfiles(ModuleID);
        //if (colLifbi.Dnn.UserProfiles.Count != 0)
        //{
        //    strXML += "<Lifbi.Dnn.UserProfiles>";

        //    foreach (Lifbi.Dnn.UserProfileInfo objLifbi.Dnn.UserProfile in colLifbi.Dnn.UserProfiles)
        //    {
        //        strXML += "<Lifbi.Dnn.UserProfile>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objLifbi.Dnn.UserProfile.Content) + "</content>";
        //        strXML += "</Lifbi.Dnn.UserProfile>";
        //    }
        //    strXML += "</Lifbi.Dnn.UserProfiles>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlLifbi.Dnn.UserProfiles = DotNetNuke.Common.Globals.GetContent(Content, "Lifbi.Dnn.UserProfiles");
        //foreach (XmlNode xmlLifbi.Dnn.UserProfile in xmlLifbi.Dnn.UserProfiles.SelectNodes("Lifbi.Dnn.UserProfile"))
        //{
        //    Lifbi.Dnn.UserProfileInfo objLifbi.Dnn.UserProfile = new Lifbi.Dnn.UserProfileInfo();
        //    objLifbi.Dnn.UserProfile.ModuleId = ModuleID;
        //    objLifbi.Dnn.UserProfile.Content = xmlLifbi.Dnn.UserProfile.SelectSingleNode("content").InnerText;
        //    objLifbi.Dnn.UserProfile.CreatedByUser = UserID;
        //    AddLifbi.Dnn.UserProfile(objLifbi.Dnn.UserProfile);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Lifbi.Dnn.UserProfileInfo> colLifbi.Dnn.UserProfiles = GetLifbi.Dnn.UserProfiles(ModInfo.ModuleID);

        //foreach (Lifbi.Dnn.UserProfileInfo objLifbi.Dnn.UserProfile in colLifbi.Dnn.UserProfiles)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objLifbi.Dnn.UserProfile.Content, objLifbi.Dnn.UserProfile.CreatedByUser, objLifbi.Dnn.UserProfile.CreatedDate, ModInfo.ModuleID, objLifbi.Dnn.UserProfile.ItemId.ToString(), objLifbi.Dnn.UserProfile.Content, "ItemId=" + objLifbi.Dnn.UserProfile.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
