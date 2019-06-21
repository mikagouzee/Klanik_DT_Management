using DocumentFormat.OpenXml.Packaging;
using System;
using WordProcessor.Generators;
using WordProcessor.Repositories;

namespace WordProcessor {
    class Program {
        public static Konsultant _konsultant { get; set; }
        static void Main(string[] args)
        {
            KonsultantRepository repo = new KonsultantRepository();
            _konsultant = repo.GetKonsultantById(new Guid("ECAEB5A5-8355-46B2-9A65-AAA07441B374"));
            using (WordprocessingDocument document = WordprocessingDocument.Create($@"D:\{_konsultant.Name}_{_konsultant.Surname}_DT_{DateTime.Today.Year}.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                FullGenerator hg = new FullGenerator();
                hg.CreateParts(document, _konsultant);

            }


        }
    }
}
