using IBHFL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.IdentityModel.Tokens;
using Rotativa;
using RusticiSoftware.HostedEngine.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace IBHFL.Controllers
{
    //[SessionExpireFilter]
    public class CertificateController : Controller
    {
        private db_m2ostEntities db = new db_m2ostEntities();

        // GET: Certificate
        [Route("download/certificate")]
        [Obsolete]
        public ActionResult CreateCertificate(int? assessmentID, int? id_user, string _attemptNo,string orgid)
        {
            var tbl_profile = getData(1, id_user, assessmentID);

            var tbl_user = getData(2, id_user, assessmentID);

            //var assessmentTitle = getData(3, id_user, assessmentID);

            var created_date = getData(4, id_user, assessmentID);

            var _fileName = id_user + "_" + assessmentID + "_" + _attemptNo + "_Certificate.pdf";


            //string path = System.Web.HttpContext.Current.Server.MapPath("~/Content/Certificates/");
            string path = @"D:\\Certificates\\Content\\";

            var _existQuery = "Select *  from tbl_certificate_log where id_user = " + id_user + " and certificateFileName = '" + _fileName + "' and id_assessment = " + assessmentID;
            var _exist = new UtilityModel().checkCertificateExistOrNot(_existQuery);

            //var _pdf = new ActionAsPdf("Index", new { _userName = tbl_profile._userName, _region = tbl_profile.region, designation = tbl_user.designation, _date = created_date.date, _department = tbl_user.department }) { FileName = _fileName };

            var _pdf = new ActionAsPdf("Index", new { _userName = tbl_profile._userName, _region = tbl_profile.region, designation = tbl_user.designation, _date = created_date.date, _department = tbl_user.department, orgid })
            {
                FileName = _fileName,
                PageOrientation = Rotativa.Options.Orientation.Landscape,
                PageSize = Rotativa.Options.Size.A4
            };

            if (!_exist)
            {

                var byteArray = _pdf.BuildPdf(ControllerContext);
                var fileStream = new FileStream(path + _fileName, FileMode.Create, FileAccess.Write);
                fileStream.Write(byteArray, 0, byteArray.Length);
                fileStream.Close();

                var _updateTable = new Certificate_log()
                {
                    id_assessment = assessmentID,
                    id_user = id_user,
                    score = Convert.ToDouble(created_date.scoring_value),
                    certificateFileName = _fileName,
                    addedDate = DateTime.Now,
                    attempt_no = Convert.ToInt32(_attemptNo),
                    pdfURL = @"https://www.m2ost.in/certificates/" + _fileName
                };

                new UtilityModel().addCertificateIntoTable(_updateTable);
            }

            return _pdf;
        }


        public ActionResult Index(string _userName, string _region, string designation, string _date, string _department ,string orgid)
        {

           

                UtilityModel certificateModel = new UtilityModel();
            string Select_theme = "2";
            List<CertificateAssignmentTheme> certificateList = certificateModel.GetCertificateDataListThem(Select_theme, orgid);
            string str1 = certificateList[0].BackgroundImageThemeSecond;
            string str2 = ConfigurationManager.AppSettings["SERVERPATH"].ToString() + "CATEGORY_IMAGE/CertificationAssessment/" + str1;
            foreach (var certifacateItem in certificateList)
            {
                certifacateItem.BackgroundImageThemeSecond = str2;
            }
            string str3 = certificateList[0].LogoImageLeftThemeSecond;
            string str4 = ConfigurationManager.AppSettings["SERVERPATH"].ToString() + "CATEGORY_IMAGE/CertificationAssessment/" + str3;
            foreach (var certifacateItem in certificateList)
            {
                certifacateItem.LogoImageLeftThemeSecond = str4;
            }
            string str5 = certificateList[0].LogoImageRightThemeSecond;
            string str6 = ConfigurationManager.AppSettings["SERVERPATH"].ToString() + "CATEGORY_IMAGE/CertificationAssessment/" + str5;
            foreach (var certifacateItem in certificateList)
            {
                certifacateItem.LogoImageRightThemeSecond = str6;
            }
            ViewData["certificateList"] = certificateList;

            TempData["_userName"] = _userName;
            TempData["region"] = _region;
            TempData["designation"] = designation;
            TempData["date"] = _date;
            TempData["department"] = _department;

            return View();

        }
        

        public ActionResult normal_certificate(string _userName, string _region, string designation, string _date, string _department, double? _score, string _title,string orgid)
        {
            
            //

            UtilityModel certificateModel = new UtilityModel();
            string Select_theme = "1";
            List<CertificateAssignmentTheme> certificateList = certificateModel.GetCertificateDataListThem(Select_theme, orgid);
            string str1 = certificateList[0].LogoImageLeftThemeFirst;
            string str2 = ConfigurationManager.AppSettings["SERVERPATH"].ToString() + "CATEGORY_IMAGE/CertificationAssessment/" + str1;
            foreach (var certifacateItem in certificateList)
            {
                certifacateItem.LogoImageLeftThemeFirst = str2;
            }
            string str3 = certificateList[0].LogoImageRightThemeFirst;
            string str4 = ConfigurationManager.AppSettings["SERVERPATH"].ToString() + "CATEGORY_IMAGE/CertificationAssessment/" + str3;
            foreach (var certifacateItem in certificateList)
            {
                certifacateItem.LogoImageRightThemeFirst = str4;
            }
            string str5 = certificateList[0].BackgroundImageThemeFirst;
            string str6 = ConfigurationManager.AppSettings["SERVERPATH"].ToString() + "CATEGORY_IMAGE/CertificationAssessment/" + str5;
            foreach (var certifacateItem in certificateList)
            {
                certifacateItem.BackgroundImageThemeFirst = str6;
            }
            ViewData["certificateList"] = certificateList;

            TempData["_userName"] = _userName;
            TempData["score"] = _score;
            TempData["title"] = _title;

            return View();

        }

        [Obsolete]
        [Route("download/certificate/download")]
        public ActionResult certificate(int? assessmentID, int? id_user, string _attemptNo,string categoryname,string orgid)
        {
            var tbl_profile = getData(1, id_user, assessmentID);

            var tbl_user = getData(2, id_user, assessmentID);

            var assessmentTitle = getData(3, id_user, assessmentID);

            var created_date = getData(4, id_user, assessmentID);

            var _fileName = id_user + "_" + assessmentID + "_" + _attemptNo + "_Certificate.pdf";


            //string path = System.Web.HttpContext.Current.Server.MapPath("~/Content/Certificates/");
            string path = @"D:\\Certificates\\Content\\";


            var _existQuery = "Select *  from tbl_certificate_log where id_user = " + id_user + " and certificateFileName = '" + _fileName + "' and id_assessment = " + assessmentID;
            var _exist = new UtilityModel().checkCertificateExistOrNot(_existQuery);




            //var _pdf = new ActionAsPdf("COE", new { _userName = tbl_profile._userName, _region = tbl_profile.region, designation = tbl_profile.designation, _date = created_date.date, _department = tbl_user.department, _score = created_date.scoring_value, _title = assessmentTitle.assessment_title }) { FileName = _fileName };
            var _pdf = new ActionAsPdf("normal_certificate", new { _userName = tbl_profile._userName, _region = tbl_profile.region, designation = tbl_user.designation, _date = created_date.date, _department = tbl_user.department, _score = created_date.scoring_value, _title = categoryname , orgid })
            {
                FileName = _fileName,
                PageOrientation = Rotativa.Options.Orientation.Landscape,
                PageSize = Rotativa.Options.Size.A4
            };

            if (!_exist)
            {

                var byteArray = _pdf.BuildPdf(ControllerContext);
                var fileStream = new FileStream(path + _fileName, FileMode.Create, FileAccess.Write);
                fileStream.Write(byteArray, 0, byteArray.Length);
                fileStream.Close();

                var _updateTable = new Certificate_log()
                {
                    id_assessment = assessmentID,
                    id_user = id_user,
                    score = Convert.ToDouble(created_date.scoring_value),
                    certificateFileName = _fileName,
                    addedDate = DateTime.Now,
                    attempt_no = Convert.ToInt32(_attemptNo),
                    pdfURL = @"https://www.m2ost.in/certificates/" + _fileName
                };

                new UtilityModel().addCertificateIntoTable(_updateTable);
            }

            return _pdf;
        }


        public UserDataForCertificate getData(int _caseCount, int? id_user, int? assessmentID)
        {
            UserDataForCertificate userDataFor = new UserDataForCertificate();
            switch (_caseCount)
            {
                case 1:
                    string sql1 = "SELECT firstname, lastname, OFFICE_ADDRESS as region FROM tbl_profile WHERE id_user = " + id_user;
                    userDataFor = new UtilityModel().getUserCertificateData(sql1, _caseCount);
                    break;

                case 2:
                    string sql2 = "Select user_designation , user_department from tbl_user where id_user= " + id_user;
                    userDataFor = new UtilityModel().getUserCertificateData(sql2, 2);
                    break;

                case 3:
                    string sql3 = "Select assessment_title from tbl_assessment where id_assessment =" + assessmentID;
                    userDataFor = new UtilityModel().getUserCertificateData(sql3, _caseCount);
                    break;

                case 4:
                    string sql4 = "Select *  from tbl_user_kpi_data_log where id_user = " + id_user + " and Content_Assessment_ID =" + assessmentID + " and KPI_Name like '%Mastery Score%'  order by scoring_value DESC limit 1;";
                    userDataFor = new UtilityModel().getUserCertificateData(sql4, 4);

                    if (string.IsNullOrEmpty(userDataFor.date))
                    {
                        sql4 = string.Empty;
                        sql4 = "Select (result_in_percentage) scoring_value, (attempt_number) AttemptNo, (updated_date_time) created_date  from tbl_rs_type_qna where id_user = " + id_user + " and id_assessment =" + assessmentID + " and attempt_number >= 1  order by  result_in_percentage DESC limit 1;";
                        userDataFor = new UtilityModel().getUserCertificateData(sql4, 4);
                    }

                    break;
            }
            return userDataFor;
        }

    }
}