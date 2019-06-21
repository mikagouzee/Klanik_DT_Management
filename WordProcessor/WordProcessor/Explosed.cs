using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using WordProcessor.Generators;
using WordProcessor.Repositories;

namespace WordProcessor {
    public class Exposed {
        public static Konsultant _konsultant { get; set; }
        public MemoryStream ExposeToApi(Guid IdKonsultant)
        {
            KonsultantRepository repo = new KonsultantRepository();
            _konsultant = repo.GetKonsultantById(IdKonsultant);
            MemoryStream ms;
            //$@"./{_konsultant.Name}_{_konsultant.Surname}_DT_{DateTime.Today.Year}.docx"
            using (ms = new MemoryStream())
            {
                using (WordprocessingDocument document = WordprocessingDocument.Create(ms, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    FullGenerator hg = new FullGenerator();
                    hg.CreateParts(document, _konsultant);

                }
            }
            return ms;
        }
    }
}
