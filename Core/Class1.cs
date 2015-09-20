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

        public void SP_Notifications(int? iud, int RecordID, string URL , string FName , string LName , string Address, string  Mobile , string Fax ,
                                    string Email , string PassportN , string Nationality , string BDate , bool? Sex , string EnteryNote , DateTime? EnteryDate ,
                                    DateTime? LeaveDate , string Organisator , string TransportType , string Destination , string HostName , string HostContact ,
                                    string EmFName , string EmLName , string EmAddress , string EmMobile , string VisitorStatus , string ProjectTitle ,string ProjectNote ,
                                    DateTime? ProjectFDate , DateTime? ProjectLDate , string Partner, bool? IsSent , string Note , string WebPage , string RegFileURL ,
                                    string MissionDesc , string Contact ,  string Desc1 , string Desc2 , int? Number , string Donors , string Term , string Proportions ,
                                    string OrgName , string ProjectStatus , string Results , bool? IsActualProjects , string ProjectResults, 
                                    string FinanceInfo , string PartnerInfo , string DepartPlan)
        {
            TryExecute(string.Format("SP_Notifications(iud = {0}, RecordID = {1}, URL = {2}, FName = {3}, LName = {4}, Address = {5}, Mobile = {6}, Fax = {7}, Email = {8}, PassportN = {9}, Nationality = {10}, BDate = {11}, Sex = {12}, EnteryNote = {13}, EnteryDate = {14}, LeaveDate = {15}, Organisator = {16}, TransportType = {17}, Destination = {18}, HostName = {19}), HostContact = {20}, EmFName = {21}, EmLName = {22}, EmAddress = {23}, EmMobile = {24}, VisitorStatus = {25}, ProjectTitle = {26}, ProjectNote = {27}, ProjectFDate  = {28}, ProjectLDate = {29}, Partner = {30}, IsSent = {31}, Note = {32}, WebPage = {33}, RegFileURL = {34},  OrgName = {35}, ProjectStatus = {36}, Results = {37}, IsActualProjects = {38}, ProjectResults = {39}, FinanceInfo = {40}, PartnerInfo = {41}, DepartPlan = {42}",
                iud, RecordID, URL , FName , LName , Address,  Mobile ,  Fax , Email ,  PassportN ,  Nationality ,  BDate ,  Sex ,  EnteryNote ,  EnteryDate ,
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
                        db.sp_Notifications(iud, ref NewID, URL, FName, LName, Address, Mobile, Fax, Email, PassportN, Nationality, BDate, Sex, EnteryNote, EnteryDate,
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

