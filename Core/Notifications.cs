using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemBase;

namespace Core
{
    public class Notifications
    {
        public int RecordID { get; set; }
        public int? NotificationTypeID { get; set; }
        public string URL { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string PassportN { get; set; }
        public string Nationality { get; set; }
        public DateTime? BDate { get; set; }
        public bool? Sex { get; set; }
        public string EnteryNote { get; set; }
        public DateTime? EnteryDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string Organisator { get; set; }
        public string TransportType { get; set; }
        public string Destination { get; set; }
        public string HostName { get; set; }
        public string HostContact { get; set; }
        public string EmFName { get; set; }
        public string EmLName { get; set; }
        public string EmAddress { get; set; }
        public string EmMobile { get; set; }
        public string VisitorStatus { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectNote { get; set; }
        public DateTime? ProjectFDate { get; set; }
        public DateTime? ProjectLDate { get; set; }
        public string Partner { get; set; }
        public bool? IsSent { get; set; }
        public string Note { get; set; }
        public string WebPage { get; set; }
        public string RegFileURL { get; set; }
        public string MissionDesc { get; set; }
        public string Contact { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public int? Number { get; set; }
        public string Donors { get; set; }
        public string Term { get; set; }
        public string Proportions { get; set; }
        public string OrgName { get; set; }
        public string ProjectStatus { get; set; }
        public string Results { get; set; }
        public bool? IsActualProjects { get; set; }
        public string ProjectResults { get; set; }
        public string FinanceInfo { get; set; }
        public string PartnerInfo { get; set; }
        public string DepartPlan { get; set; }
    }
    public class NoficicationsRepository : ObjectBase
    {
        public int? ID { get; set; }
        public List<Notifications> ListNotifications(int? RecordID)
        {
            return TryToReturn(string.Format("Core.CM.NewsRepository.ListNews()"), () =>
            {
                using (var db = DB.DBCon.GetToolsDataContext())
                {
                    return db.fn_List_Notifications(RecordID).Select(s => new Notifications
                    {
                        RecordID = s.RecordID,
		                URL = s.URL,
		                FName = s.FName,
		                LName = s.LName,
		                Address = s.Address,
		                Mobile = s.Mobile,
		                Fax = s.Fax,
		                Email = s.Email,
		                PassportN = s.PassportN,
		                Nationality = s.Nationality,
		                BDate = s.BDate,
		                Sex = s.Sex,
		                EnteryNote = s.EnteryNote,
		                EnteryDate = s.EnteryDate,
		                LeaveDate = s.LeaveDate,
		                Organisator =s.Organisator,
		                TransportType = s.TransportType,
		                Destination = s.Destination,
		                HostName = s.HostName,
		                HostContact = s.HostContact,
		                EmFName = s.EmFName,
		                EmLName = s.EmLName,
		                EmAddress = s.EmAddress,
		                EmMobile = s.EmMobile,
		                VisitorStatus = s.VisitorStatus,
		                ProjectTitle = s.ProjectTitle,
		                ProjectNote = s.ProjectNote,
		                ProjectFDate = s.ProjectFDate,
                        ProjectLDate = s.ProjectLDate,
		                Partner = s.Partner,
                        IsSent = s.IsSent,
		                Note  = s.Note,
		                WebPage = s.WebPage,
		                RegFileURL = s.RegFileURL,
		                MissionDesc = s.MissionDesc,
		                Contact = s.Contact,
		                Desc1 = s.Desc1,
                        Desc2 = s.Desc2,
		                Number = s.Number,
		                Donors = s.Donors,
		                Term = s.Term,
		                Proportions = s.Proportions,
		                OrgName = s.OrgName,
		                ProjectStatus = s.ProjectStatus,
		                Results = s.Results,
		                IsActualProjects = s.IsActualProjects,
		                ProjectResults = s.ProjectResults,
		                FinanceInfo = s.FinanceInfo,
		                PartnerInfo = s.PartnerInfo,
                        DepartPlan = s.DepartPlan
                    }).ToList();
                }
            });
        }

        public void SP_Notifications(int? iud, int? RecordID = null, int? NotificationTypeID=null, string URL = null, string FName = null, string LName = null, string Address = null, string Mobile = null, string Fax = null,
                                    string Email = null, string PassportN = null, string Nationality = null, DateTime? BDate = null, bool? Gender = null, string EnteryNote = null, DateTime? EnteryDate = null,
                                    DateTime? LeaveDate = null, string Organisator = null, string TransportType = null, string Destination = null, string HostName = null, string HostContact = null,
                                    string EmFName = null, string EmLName = null, string EmAddress = null, string EmMobile = null, string VisitorStatus = null, string ProjectTitle = null, string ProjectNote = null,
                                    DateTime? ProjectFDate = null, DateTime? ProjectLDate = null, string Partner = null, bool? IsSent = null, string Note = null, string WebPage = null, string RegFileURL = null,
                                    string MissionDesc = null, string Contact = null, string Desc1 = null, string Desc2 = null, int? Number = null, string Donors = null, string Term = null, string Proportions = null,
                                    string OrgName = null, string ProjectStatus = null, string Results = null, bool? IsActualProjects = null, string ProjectResults = null,
                                    string FinanceInfo = null, string PartnerInfo = null, string DepartPlan = null)
        {
            TryExecute(string.Format("SP_Notifications(iud = {0}, RecordID = {1}, URL = {2}, FName = {3}, LName = {4}, Address = {5}, Mobile = {6}, Fax = {7}, Email = {8}, PassportN = {9}, Nationality = {10}, BDate = {11}, Sex = {12}, EnteryNote = {13}, EnteryDate = {14}, LeaveDate = {15}, Organisator = {16}, TransportType = {17}, Destination = {18}, HostName = {19}), HostContact = {20}, EmFName = {21}, EmLName = {22}, EmAddress = {23}, EmMobile = {24}, VisitorStatus = {25}, ProjectTitle = {26}, ProjectNote = {27}, ProjectFDate  = {28}, ProjectLDate = {29}, Partner = {30}, IsSent = {31}, Note = {32}, WebPage = {33}, RegFileURL = {34},  OrgName = {35}, ProjectStatus = {36}, Results = {37}, IsActualProjects = {38}, ProjectResults = {39}, FinanceInfo = {40}, PartnerInfo = {41}, DepartPlan = {42}",
                iud, RecordID, URL, FName, LName, Address, Mobile, Fax, Email, PassportN, Nationality, BDate, Gender, EnteryNote, EnteryDate,
                                     LeaveDate ,  Organisator ,  TransportType ,  Destination ,  HostName ,  HostContact ,
                                     EmFName ,  EmLName ,  EmAddress ,  EmMobile ,  VisitorStatus ,  ProjectTitle , ProjectNote ,
                                     ProjectFDate , ProjectLDate ,  Partner,  IsSent ,  Note ,  WebPage ,  RegFileURL ,
                                     MissionDesc ,  Contact ,   Desc1 ,  Desc2 ,  Number ,  Donors , Term ,  Proportions ,
                                     OrgName ,  ProjectStatus ,  Results ,  IsActualProjects ,  ProjectResults, 
                                     FinanceInfo ,  PartnerInfo ,  DepartPlan ), () =>
                {
                    using (var db = DB.DBCon.GetToolsDataContext())
                    {
                        int? NewID = RecordID;
                        db.sp_Notifications(iud, ref NewID, NotificationTypeID, URL, FName, LName, Address, Mobile, Fax, Email, PassportN, Nationality, BDate, Gender, EnteryNote, EnteryDate,
                                     LeaveDate, Organisator, TransportType, Destination, HostName, HostContact,
                                     EmFName, EmLName, EmAddress, EmMobile, VisitorStatus, ProjectTitle, ProjectNote,
                                     ProjectFDate, ProjectLDate, Partner, IsSent, Note, WebPage, RegFileURL,
                                     MissionDesc, Contact, Desc1, Desc2, Number, Donors, Term, Proportions,
                                     OrgName, ProjectStatus, Results, IsActualProjects, ProjectResults,
                                     FinanceInfo, PartnerInfo, DepartPlan);
                        this.ID = RecordID;
                    }
                });
        }

    }
}

