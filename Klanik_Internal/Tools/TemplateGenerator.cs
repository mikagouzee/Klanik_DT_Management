using Klanik_Internal.Models;
using Klanik_Internal.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klanik_Internal.Tools
{
    public class TemplateGenerator : IGenerator
    {
        private readonly IService<Konsultant> _service;
        private readonly IMapper _mapper;
        public TemplateGenerator(IService<Konsultant> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public string GetCvTemplate(Guid id)
        {
            var konsultant = _mapper.ToPdfModel( _service.GetById(id));
            //todo : replace this by a config value;
            var assetsFolder = "file://C:/Users/Mika/source/Github_repos/Klanik_DT/Klanik_Internal/Klanik_Internal/PdfAssets";

            List<OwnedCompetences> firstHalfSkill = new List<OwnedCompetences>();

            List<OwnedCompetences> secondHalfSkill = new List<OwnedCompetences>();

            string maincompetence = "Ready for everything!"; 


            if (konsultant.Competences.Count > 0)
            {
                for (int i = 0; i < konsultant.Competences.Count; i++)
                {
                    if (i < konsultant.Competences.Count / 2)
                        firstHalfSkill.Add(konsultant.Competences[i]);
                    else
                        secondHalfSkill.Add(konsultant.Competences[i]);
                }

                maincompetence = konsultant.Competences.OrderByDescending(x => x.Rating).FirstOrDefault().Competence.Name;
            }






            var sb = new StringBuilder();

            #region css and body declaration
            sb.Append($@"
                    <html>
                        <head>
                        <style>
                                @media print, screen{{
                                    .footer{{
                                      display:grid;
                                      grid-template-columns: 30% 50% 20%;
                                      margin-left:50px;
                                        color:white;
                                    }}
                                      .PSA{{
                                        grid - column: 1;
                                        background-color: #304d6f;

                                      }}
                                      .contact{{
                                        grid - column:2;
                                        background-color:#4d7dad;
                                      }}
                                      .pageNumber{{
                                        grid - column:3;                                        
                                        justify-self: stretch;
                                        text-align:right;
                                        background-color:#041d36;
                                      }}


                                    .header{{
                                      page-break-before:always;
                                      display:grid;
                                      align-content: center;
                                      justify-self: center;
                                    }}

                                    .header img{{
                                        max-height:100px;
                                    }}


                                    @font-face{{
                                        font-family:'NewJuneBold';
                                        src:url('{assetsFolder}/fonts/NewJune-Bold.otf');
                                    }}

                                    @font-face {{
                                      font-family: 'Titillium';
                                      src: url('{assetsFolder}/fonts/TitilliumWeb-Regular.ttf');
                                    }}

                                    @font-face {{
                                      font-family:'Titillium-title';
                                      src: url('{assetsFolder}/fonts/TitilliumWeb-Bold.ttf')
                                    }}

                                    .CV{{
                                        display:grid;
                                        font-family:Titillium
                                    }}


                                    .Klanik-logo{{
                                      grid - column:1;
                                      grid-row:1/ span 2;
                                    }}

                                    .box-header{{
                                        /* display:flex;
                                        flex-wrap: wrap;
                                        justify-content:space-between; 
                                        border:1px solid black; */

                                        display:grid;
                                        grid-template-columns:40% 60%;
                                        grid-template-rows:50% 50%;    

                                    }}
                                    .logo{{
                                      width:100%;
                                      height:100%;
                                    }}

                                    .Klanik-titleBar{{
                                        grid-column:2;
                                        grid-row:2;
                                        font-family:NewJuneBold;
                                        font-size:40px;
                                        background-color:#041d36;
                                        color:white;
                                        text-align:right;
                                        padding:5px;
                                        margin-right:5px;
                                    }}

                                    .box-infos{{
                                        grid-column:2;
                                        grid-row:1;
                                        display:grid; 
                                        grid-template-columns: 50% 50%;
    
                                        align-content: center;
                                        font-family:Titillium-title;
                                    }}

                                    .box-name{{
                                        grid - column:1;   
                                        /* order:1; */
                                        align-self:stretch;
                                        text-align:center;
                                        margin-top:auto;
                                        margin-bottom:auto;
                                        font-size:150%;
                                        /* border:1px solid black; */
                                    }}

                                    .box-summary{{
                                        grid-column:2;
                                        align-self:stretch;
                                        /* font-size:125%; */
                                        /* border:1px solid black; */
                                    }}

                                    section{{
                                      padding:20px;
                                    }}

                                    .row-competences .section-content{{
                                      display:grid;
                                      grid-template-columns: 50% 50%;
                                      grid-template-rows:auto;
                                      grid-row-gap: 15px;
                                      grid-column-gap:15px;
                                      justify-content:stretch;
                                      align-items:left;
                                    }}

                                    .box-competences{{
                                      grid-column: 1/span 2;
                                      grid-row: 1;
                                      display:grid;
                                      grid-template-columns: 50% 50%;

                                      justify-self: stretch;
                                    }}

                                    td.skill {{
                                        background-color:ghostwhite;
                                        padding: 3px;
                                        text-align: center;
                                    }}

                                    .skillTable1 {{
                                        grid-column:1;    
                                        border-collapse: separate;
                                        border-spacing: 5px 1px;
                                        margin-right: 25px;
                                        width: 100%;
                                        height:100%;
                                        text-align:center;
                                    }}

                                    .skillTable2 {{
                                        grid-column:2;    
                                        border-collapse: separate;
                                        border-spacing: 5px 1px;
                                        margin-right: 25px;
                                        width: 100%;
                                        height:100%;
                                        text-align:center;
                                    }}

                                    .section-content{{
                                      margin-left:50px;
                                    }}

                                    .box-languages{{
                                      margin-left:25px;
                                      grid-column: 1;
                                      grid-row:2;
                                      justify-self: stretch;

                                    }}

                                    .box-legend{{
                                      grid-column:2;
                                      grid-row:2;
                                    }}

                                    
                                    .section-title{{
                                      font-family: 'Titillium-Title';
                                      display:grid;

                                      grid-template-columns: 5% 95%;
                                      align-items:center;
                                      color:white;
                                      font-style:bold;                                      
                                    }}

                                    .section-title img{{
                                      grid-column:1;
                                      height: 50px;
                                      margin-right:5px;
                                      z-index:1;
                                      align-self:center;
                                    }}

                                    .section-title h2{{
                                      grid-column:2;
                                        align-self:center;
                                      padding:-5px;
                                      padding-left:20px;

                                      background-clip: padding-box;
                                      background-color:#4d7dad;
                                    }}

                                    .table-header{{
                                      background-color:#1d3652;
                                      color:white;
                                      margin:5px;
                                      padding:5px;
                                      font-style: bold;
                                    }}

                                    .table {{
                                      border-collapse: collapse;
                                      padding:5px;
                                      height:100%;
                                      width:100%;
                                      text-align:center;
                                    }}
                                    .table td, .table th {{
                                      border: 1px solid lightgrey;
                                      width:auto;  
                                    }}
                                    .table tr:first-child th {{
                                      border-top: 0;
                                    }}

                                    .table tr td:first-child,
                                    .table tr th:first-child {{
                                      border-left: 0;
                                    }}
                                    .table tr td:last-child,
                                    .table tr th:last-child {{
                                      border-right: 0;
                                    }}
                    
                        }}
                    </style>
                    </head>
                    <body>
                    <div class='CV'>
                      ");
            #endregion

            #region box header
            sb.Append($@"
                <section class='box-header'>
                   
                    <div class='Klanik-logo'>
                        <img src='{assetsFolder}/pictos/logo1.png' alt='klanik-logo' class='logo'>
                    </div>
                  
                    <div class='Klanik-titleBar'>
                        Klanik Consulting
                    </div>
              
                    <div class='box-infos'>
                        <div class='box-name'>
                            {konsultant.Name} {konsultant.Surname}
                        </div>
    
                        <div class='box-summary'>
                            {konsultant.Function}
                            <br>
                            {maincompetence}
                            <br>
                            Available starting { (konsultant.Availability.Date.ToString("d").Length > 0 ? konsultant.Availability.Date.ToString("d") : DateTime.Now.Date.ToString("d")) }
                        </div>
                    </div>  
                </section>
            ");
            #endregion

            #region row competences
            sb.Append($@"
                <section class='row-competences'>
                  <div class='section-title'>
                          <img src='{assetsFolder}/pictos/competence.png' alt='comp-icon' align='top'> <h2> Competences</h2>
                  </div>

                  <div class='section-content'>
                      <div class='box-competences'>

                        <table class=' skillTable1'>");
                        foreach (var comp in firstHalfSkill)
                        {
                            sb.Append($@"
                                <tr>
                                    <td class='skill'>{comp.Competence.Name}</td>
                                    <td class='skill'>{comp.Rating}</td>
                                </tr>
                            ");
                        }
            sb.Append($@"
                        </table>
                        <table class='skillTable2'>");
                        foreach (var comp in secondHalfSkill)
                        {
                            sb.Append($@"
                                            <tr>
                                                <td class='skill'>{comp.Competence.Name}</td>
                                                <td class='skill'>{comp.Rating}</td>
                                            </tr>
                                        ");
                        }
            sb.Append($@"</table>
                        </div>

                      <div class='box-languages'>
                              <!-- <h3> Languages</h3> -->
                              <table class='table'>
            ");
                        foreach (var lang in konsultant.Languages)
            {
                sb.Append($@"
                    <tr>
                        <td class='table'>{lang.Language.Name}</td>
                        <td class='table'>{lang.Fluency}</td>
                    </tr>
                ");
            }

            sb.Append($@"</table>
                            </div>
                  
                              <div class='box-legend'>
                                  « I have some competences <br>
                                  «« I know how to do but I need support <br>
                                  ««« Good level <br>
                                  «««« Very good level / mastering the topic <br>
                                  ««««« Subject Matter Expert 
                              </div>
                  </div>
                
          </section>
            ");
            #endregion

            #region row education
            sb.Append($@"
                 <section class='row-education'>
                      <div class='section-title'>
                              <img src='{assetsFolder}/pictos/education.png' alt='edu-icon'><h2>Education</h2>
                      </div>
                      <div class='section-content'>
                          <table>");
                          foreach (var edu in konsultant.Educations)
            {
                sb.Append($@"
                              <tr>
                                  <td>{edu.StartDate.Date.ToString("d")} to {edu.EndDate.Date.ToString("d")} </td>
                                  <td>{edu.Education.Name}</td>
                              </tr>");
            }
            sb.Append($@"
                          </table>
                      </div>
                </section>
            ");
            #endregion

            #region row certificate
            sb.Append($@"
                 <section class='row-certificate'>
                    <div class='section-title'>
                        <img src='{assetsFolder}/pictos/certificate.png' alt='cert-icon'><h2>Certificates/Clearance</h2>
                    </div>

                    <div class='section-content'>
                        <table>");
                       foreach (var cert in konsultant.Certificates)
            {
                sb.Append($@"
                            <tr>
                                <td>{cert.Obtension.Date.ToString("d")} </td>
                                <td>{cert.Certificate.Name}</td>
                            </tr>");
            }
            sb.Append($@"
                    </table>
                    </div>
                </section>
            ");
            #endregion

            #region row summary
            sb.Append($@"
                <section class='row-summary'>
                  <div class='section-title'>
                          <img src='{assetsFolder}/pictos/summary.png' alt='sum-icon'><h2>Summary of Professional Experiences</h2>
                  </div>

                  <div class='section-content'>
                          <table class='table'>
                              <tr class='table'>
                                  <td class='table table-header'>From month/year till month/year </td> <td class='table-header'> Company </td> <td class='table-header'>Position</td>
                              </tr>
            ");
            foreach (var prof in konsultant.ProfessionalExperiences)
            {
                sb.Append($@"

                              <tr >
                                  <td class='table'>From {prof.StartDate.Date.ToString("d")} to {prof.EndDate.Date.ToString("d")} </td> 
                                  <td class='table'>{prof.Customer} </td> 
                                  <td class='table'> {prof.Position}</td>
                              </tr>");
            }
            sb.Append($@"
                          </table>
                  </div>
                </section>
            ");
            #endregion

            #region FOOTER AND HEADER
            sb.Append($@"
                <section class='footer'>
                    <div class='PSA'>KLANIK Atypic Konsultants</div>
                    <div class='contact'>Contact KLANIK : </div>
                    <div class='pageNumber'> 1</div>
                </section>

                <div class='header' style='page-break-before:always;'>
                    <img src = '{assetsFolder}/pictos/KlanikLogo.png' alt='header-icon'>
                </div>
            ");
            #endregion

            #region row experience
            sb.Append($@"
                 <section class='row-experience'>
                  <div class='section-title'>
                          <img src='{assetsFolder}/pictos/experience.png' alt='exp-icon'><h2>Professional Experiences</h2>
                  </div>
                  <div class='section-content'>
                      <ul>");

            foreach (var prof in konsultant.ProfessionalExperiences)
            {
                sb.Append($@"
                              <li >
                                  From {prof.StartDate.Date.ToString("d")} till {prof.EndDate.Date.ToString("d")} : {prof.Customer}<br>
                                  Role : {prof.Position}<br>
                                  {prof.Summary}<br>
                                  <h5>Details of Accomplishments :</h5>
                                  <ul>");

                                foreach (var accomp in prof.Accomplishments.Where(a => a.IsRelevant))
                {
                    sb.Append($@"<li>--{{accomp.title}} : {{accomp.summary}}</li>");
                }
                sb.Append($@"
                                  </ul>
                                  <h5>Technical Environment :</h5>
                                  <ul>");
                                foreach (var tech in prof.TechnicalEnvironments.Where(t => t.IsRelevant))
                {
                    sb.Append($@"<li>--{{tech.name}} {{tech.option}}</li>");
                }
                sb.Append($@"
                                  </ul>
                              </li>");
            }


            sb.Append($@"
                      </ul>
                  </div>  
                </section>
            ");
            #endregion

            #region row references
            sb.Append($@"
                <section class='row-reference'>
                  <div class='section-title'>
                          <img src='{assetsFolder}/pictos/reference.png' alt='ref-icon'><h2>Professional References</h2>
                  </div>
                  <div class='section-content'>
                          <ul>");
            foreach (var refer in konsultant.ProfessionalReferences)
            {
                sb.Append($@"<li>{refer.Surname} , {refer.Name}, {refer.Function}, {refer.Contacts.Mail}, {refer.Contacts.Phone}</li>");
            }

            sb.Append($@"
                          </ul>
                  </div>
                </section>
            ");
            #endregion

            #region body closures
            sb.Append($@"
            </div>
            </body>
            </html>
            ");

            #endregion

            return sb.ToString();
        }

    }


    public interface IGenerator
    {
        string GetCvTemplate(Guid id);
    }
}
