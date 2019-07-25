using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.Linq;
using static WordProcessor.Model.ModelEnums;
using A = DocumentFormat.OpenXml.Drawing;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;
using Pic = DocumentFormat.OpenXml.Drawing.Pictures;
using Wp = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using Wp14 = DocumentFormat.OpenXml.Office2010.Word.Drawing;

namespace WordProcessor.Generators {
    public static class MainDocumentParts {
        public static void GenerateMainDocumentPart1Content(MainDocumentPart mainDocumentPart1, Konsultant _Konsultant)
        {
            Document document1 = new Document() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 w16se w16cid wp14" } };
            document1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            document1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            document1.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            document1.AddNamespaceDeclaration("cx2", "http://schemas.microsoft.com/office/drawing/2015/10/21/chartex");
            document1.AddNamespaceDeclaration("cx3", "http://schemas.microsoft.com/office/drawing/2016/5/9/chartex");
            document1.AddNamespaceDeclaration("cx4", "http://schemas.microsoft.com/office/drawing/2016/5/10/chartex");
            document1.AddNamespaceDeclaration("cx5", "http://schemas.microsoft.com/office/drawing/2016/5/11/chartex");
            document1.AddNamespaceDeclaration("cx6", "http://schemas.microsoft.com/office/drawing/2016/5/12/chartex");
            document1.AddNamespaceDeclaration("cx7", "http://schemas.microsoft.com/office/drawing/2016/5/13/chartex");
            document1.AddNamespaceDeclaration("cx8", "http://schemas.microsoft.com/office/drawing/2016/5/14/chartex");
            document1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            document1.AddNamespaceDeclaration("aink", "http://schemas.microsoft.com/office/drawing/2016/ink");
            document1.AddNamespaceDeclaration("am3d", "http://schemas.microsoft.com/office/drawing/2017/model3d");
            document1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            document1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            document1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            document1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            document1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            document1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            document1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            document1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            document1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            document1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            document1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            document1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            document1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            document1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Body body1 = new Body();

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "003E0279", RsidRunAdditionDefault = "003E0279" };
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            NoProof noProof1 = new NoProof();

            runProperties1.Append(noProof1);

            Drawing drawing1 = new Drawing();

            Wp.Anchor anchor1 = new Wp.Anchor() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)114300U, DistanceFromRight = (UInt32Value)114300U, SimplePos = false, RelativeHeight = (UInt32Value)251658240U, BehindDoc = false, Locked = false, LayoutInCell = true, AllowOverlap = true };
            Wp.SimplePosition simplePosition1 = new Wp.SimplePosition() { X = 0L, Y = 0L };

            Wp.HorizontalPosition horizontalPosition1 = new Wp.HorizontalPosition() { RelativeFrom = Wp.HorizontalRelativePositionValues.Column };
            Wp.PositionOffset positionOffset1 = new Wp.PositionOffset();
            positionOffset1.Text = "-692150";

            horizontalPosition1.Append(positionOffset1);

            Wp.VerticalPosition verticalPosition1 = new Wp.VerticalPosition() { RelativeFrom = Wp.VerticalRelativePositionValues.Paragraph };
            Wp.PositionOffset positionOffset2 = new Wp.PositionOffset();
            positionOffset2.Text = "53340";

            verticalPosition1.Append(positionOffset2);
            Wp.Extent extent1 = new Wp.Extent() { Cx = 7160400L, Cy = 431739L };
            Wp.EffectExtent effectExtent1 = new Wp.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 635L };
            Wp.WrapNone wrapNone1 = new Wp.WrapNone();
            Wp.DocProperties docProperties1 = new Wp.DocProperties() { Id = (UInt32Value)5U, Name = "Image 5" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties1 = new Wp.NonVisualGraphicFrameDrawingProperties();

            A.GraphicFrameLocks graphicFrameLocks1 = new A.GraphicFrameLocks() { NoChangeAspect = true };
            graphicFrameLocks1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            nonVisualGraphicFrameDrawingProperties1.Append(graphicFrameLocks1);

            A.Graphic graphic1 = new A.Graphic();
            graphic1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData1 = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture1 = new Pic.Picture();
            picture1.AddNamespaceDeclaration("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture");

            Pic.NonVisualPictureProperties nonVisualPictureProperties1 = new Pic.NonVisualPictureProperties();
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties1 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)5U, Name = "COMPETENCES.png" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new Pic.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties1.Append(nonVisualDrawingProperties1);
            nonVisualPictureProperties1.Append(nonVisualPictureDrawingProperties1);

            Pic.BlipFill blipFill1 = new Pic.BlipFill();

            A.Blip blip1 = new A.Blip() { Embed = "rId8", CompressionState = A.BlipCompressionValues.Print };

            A.BlipExtensionList blipExtensionList1 = new A.BlipExtensionList();

            A.BlipExtension blipExtension1 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi1 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi1.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension1.Append(useLocalDpi1);

            blipExtensionList1.Append(blipExtension1);

            blip1.Append(blipExtensionList1);

            A.Stretch stretch1 = new A.Stretch();
            A.FillRectangle fillRectangle1 = new A.FillRectangle();

            stretch1.Append(fillRectangle1);

            blipFill1.Append(blip1);
            blipFill1.Append(stretch1);

            Pic.ShapeProperties shapeProperties1 = new Pic.ShapeProperties();

            A.Transform2D transform2D1 = new A.Transform2D();
            A.Offset offset1 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents() { Cx = 7160400L, Cy = 431739L };

            transform2D1.Append(offset1);
            transform2D1.Append(extents1);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);

            shapeProperties1.Append(transform2D1);
            shapeProperties1.Append(presetGeometry1);

            picture1.Append(nonVisualPictureProperties1);
            picture1.Append(blipFill1);
            picture1.Append(shapeProperties1);

            graphicData1.Append(picture1);

            graphic1.Append(graphicData1);

            Wp14.RelativeWidth relativeWidth1 = new Wp14.RelativeWidth() { ObjectId = Wp14.SizeRelativeHorizontallyValues.Page };
            Wp14.PercentageWidth percentageWidth1 = new Wp14.PercentageWidth();
            percentageWidth1.Text = "0";

            relativeWidth1.Append(percentageWidth1);

            Wp14.RelativeHeight relativeHeight1 = new Wp14.RelativeHeight() { RelativeFrom = Wp14.SizeRelativeVerticallyValues.Page };
            Wp14.PercentageHeight percentageHeight1 = new Wp14.PercentageHeight();
            percentageHeight1.Text = "0";

            relativeHeight1.Append(percentageHeight1);

            anchor1.Append(simplePosition1);
            anchor1.Append(horizontalPosition1);
            anchor1.Append(verticalPosition1);
            anchor1.Append(extent1);
            anchor1.Append(effectExtent1);
            anchor1.Append(wrapNone1);
            anchor1.Append(docProperties1);
            anchor1.Append(nonVisualGraphicFrameDrawingProperties1);
            anchor1.Append(graphic1);
            anchor1.Append(relativeWidth1);
            anchor1.Append(relativeHeight1);

            drawing1.Append(anchor1);

            run1.Append(runProperties1);
            run1.Append(drawing1);

            paragraph1.Append(bookmarkStart1);
            paragraph1.Append(bookmarkEnd1);
            paragraph1.Append(run1);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "00D15E30", RsidRunAdditionDefault = "004C1D0B" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { After = "0" };

            paragraphProperties1.Append(spacingBetweenLines1);

            paragraph2.Append(paragraphProperties1);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphAddition = "00D15E30", RsidParagraphProperties = "00D15E30", RsidRunAdditionDefault = "00D15E30" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();

            Tabs tabs1 = new Tabs();
            TabStop tabStop1 = new TabStop() { Val = TabStopValues.Left, Position = 2851 };

            tabs1.Append(tabStop1);
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { After = "0" };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            Italic italic1 = new Italic();
            Languages languages1 = new Languages() { Val = "fr-BE" };

            paragraphMarkRunProperties1.Append(italic1);
            paragraphMarkRunProperties1.Append(languages1);

            paragraphProperties2.Append(tabs1);
            paragraphProperties2.Append(spacingBetweenLines2);
            paragraphProperties2.Append(paragraphMarkRunProperties1);



            paragraph3.Append(paragraphProperties2);



            Paragraph paragraph5 = new Paragraph() { RsidParagraphMarkRevision = "00D15E30", RsidParagraphAddition = "00D15E30", RsidParagraphProperties = "00D15E30", RsidRunAdditionDefault = "00D15E30" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();

            Tabs tabs3 = new Tabs();
            TabStop tabStop3 = new TabStop() { Val = TabStopValues.Left, Position = 2851 };

            tabs3.Append(tabStop3);
            SpacingBetweenLines spacingBetweenLines4 = new SpacingBetweenLines() { After = "0" };

            ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
            Italic italic30 = new Italic();
            Languages languages30 = new Languages() { Val = "fr-BE" };

            paragraphMarkRunProperties3.Append(italic30);
            paragraphMarkRunProperties3.Append(languages30);

            paragraphProperties4.Append(tabs3);
            paragraphProperties4.Append(spacingBetweenLines4);
            paragraphProperties4.Append(paragraphMarkRunProperties3);

            paragraph5.Append(paragraphProperties4);



            Table tableCompetence = new Table();


            List<OwnedCompetence> skils = new List<OwnedCompetence>();
            skils = _Konsultant.OwnedCompetence.ToList();
            TableGenerator tableGenerator = new TableGenerator();
            tableGenerator.GenerateSkillsTable(tableCompetence, skils);

            Paragraph paragraph22 = new Paragraph() { RsidParagraphAddition = "004C1D0B", RsidRunAdditionDefault = "004C1D0B" };
            //Table LNG
            Table table2 = new Table();

            TableProperties tableProperties2 = new TableProperties();
            TableStyle tableStyle1 = new TableStyle() { Val = "Grilledutableau" };
            TableWidth tableWidth2 = new TableWidth() { Width = "10413", Type = TableWidthUnitValues.Dxa };
            TableIndentation tableIndentation2 = new TableIndentation() { Width = -287, Type = TableWidthUnitValues.Dxa };

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder17 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder17 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder17 = new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder5 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder17);
            tableBorders1.Append(leftBorder17);
            tableBorders1.Append(bottomBorder17);
            tableBorders1.Append(rightBorder5);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);
            TableLook tableLook2 = new TableLook() { Val = "04A0" };

            tableProperties2.Append(tableStyle1);
            tableProperties2.Append(tableWidth2);
            tableProperties2.Append(tableIndentation2);
            tableProperties2.Append(tableBorders1);
            tableProperties2.Append(tableLook2);

            TableGrid tableGrid2 = new TableGrid();
            GridColumn gridColumn5 = new GridColumn() { Width = "5359" };
            GridColumn gridColumn6 = new GridColumn() { Width = "5054" };

            tableGrid2.Append(gridColumn5);
            tableGrid2.Append(gridColumn6);

            TableRow tableRow5 = new TableRow() { RsidTableRowMarkRevision = "004C1D0B", RsidTableRowAddition = "004C1D0B", RsidTableRowProperties = "00820EBF" };

            TableRowProperties tableRowProperties5 = new TableRowProperties();
            TableRowHeight tableRowHeight5 = new TableRowHeight() { Val = (UInt32Value)1203U };

            tableRowProperties5.Append(tableRowHeight5);

            TableCell tableCell17 = new TableCell();

            TableCellProperties tableCellProperties17 = new TableCellProperties();
            TableCellWidth tableCellWidth17 = new TableCellWidth() { Width = "5359", Type = TableWidthUnitValues.Dxa };

            tableCellProperties17.Append(tableCellWidth17);

            Table TableLangues = new Table();

            foreach (var lang in _Konsultant.KnownLanguage)
            {
                TableProperties tableProperties3 = new TableProperties();
                TableWidth tableWidth3 = new TableWidth() { Width = "5128", Type = TableWidthUnitValues.Dxa };
                TableIndentation tableIndentation3 = new TableIndentation() { Width = 12, Type = TableWidthUnitValues.Dxa };

                TableBorders tableBorders2 = new TableBorders();
                TopBorder topBorder18 = new TopBorder() { Val = BorderValues.Single, Color = "D9D9D9", ThemeColor = ThemeColorValues.Background1, ThemeShade = "D9", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
                BottomBorder bottomBorder18 = new BottomBorder() { Val = BorderValues.Single, Color = "D0CECE", ThemeColor = ThemeColorValues.Background2, ThemeShade = "E6", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
                InsideHorizontalBorder insideHorizontalBorder2 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "D0CECE", ThemeColor = ThemeColorValues.Background2, ThemeShade = "E6", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
                InsideVerticalBorder insideVerticalBorder2 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "D0CECE", ThemeColor = ThemeColorValues.Background2, ThemeShade = "E6", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

                tableBorders2.Append(topBorder18);
                tableBorders2.Append(bottomBorder18);
                tableBorders2.Append(insideHorizontalBorder2);
                tableBorders2.Append(insideVerticalBorder2);
                TableLook tableLook3 = new TableLook() { Val = "0000" };

                tableProperties3.Append(tableWidth3);
                tableProperties3.Append(tableIndentation3);
                tableProperties3.Append(tableBorders2);
                tableProperties3.Append(tableLook3);
                TableGrid tableGrid3 = new TableGrid();
                GridColumn gridColumn7 = new GridColumn() { Width = "1227" };
                GridColumn gridColumn8 = new GridColumn() { Width = "3901" };

                tableGrid3.Append(gridColumn7);
                tableGrid3.Append(gridColumn8);
                TableRow tableRow6 = new TableRow() { RsidTableRowMarkRevision = "004C1D0B", RsidTableRowAddition = "004C1D0B", RsidTableRowProperties = "003F77BB" };

                TableRowProperties tableRowProperties6 = new TableRowProperties();
                TableRowHeight tableRowHeight6 = new TableRowHeight() { Val = (UInt32Value)696U };

                tableRowProperties6.Append(tableRowHeight6);
                Paragraph paragraph23 = new Paragraph() { RsidParagraphMarkRevision = "006A08FF", RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "00820EBF", RsidRunAdditionDefault = "003F77BB" };

                TableCell tableCell18 = new TableCell();

                TableCellProperties tableCellProperties18 = new TableCellProperties();
                TableCellWidth tableCellWidth18 = new TableCellWidth() { Width = "1227", Type = TableWidthUnitValues.Dxa };
                Shading shading18 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "FFFFFF", ThemeFill = ThemeColorValues.Background1 };
                TableCellVerticalAlignment tableCellVerticalAlignment17 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

                tableCellProperties18.Append(tableCellWidth18);
                tableCellProperties18.Append(shading18);
                tableCellProperties18.Append(tableCellVerticalAlignment17);
                ParagraphProperties paragraphProperties21 = new ParagraphProperties();
                Indentation indentation1 = new Indentation() { Start = "61", End = "-191" };

                ParagraphMarkRunProperties paragraphMarkRunProperties20 = new ParagraphMarkRunProperties();
                RunFonts runFonts45 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                Bold bold8 = new Bold();
                FontSize fontSize45 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript45 = new FontSizeComplexScript() { Val = "20" };

                paragraphMarkRunProperties20.Append(runFonts45);
                paragraphMarkRunProperties20.Append(bold8);
                paragraphMarkRunProperties20.Append(fontSize45);
                paragraphMarkRunProperties20.Append(fontSizeComplexScript45);

                paragraphProperties21.Append(indentation1);
                paragraphProperties21.Append(paragraphMarkRunProperties20);
                Run run57 = new Run();

                RunProperties runProperties57 = new RunProperties();
                RunFonts runFonts46 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                Bold bold9 = new Bold();
                FontSize fontSize46 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript46 = new FontSizeComplexScript() { Val = "20" };

                runProperties57.Append(runFonts46);
                runProperties57.Append(bold9);
                runProperties57.Append(fontSize46);
                runProperties57.Append(fontSizeComplexScript46);
                Text text36 = new Text();
                text36.Text = lang.Language.Name;

                run57.Append(runProperties57.CloneNode(true));
                run57.Append(text36);

                paragraph23.Append(paragraphProperties21);
                paragraph23.Append(run57);

                tableCell18.Append(tableCellProperties18);
                tableCell18.Append(paragraph23);

                TableCell tableCell19 = new TableCell();

                TableCellProperties tableCellProperties19 = new TableCellProperties();
                TableCellWidth tableCellWidth19 = new TableCellWidth() { Width = "3901", Type = TableWidthUnitValues.Dxa };
                Shading shading19 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "FFFFFF", ThemeFill = ThemeColorValues.Background1 };
                TableCellVerticalAlignment tableCellVerticalAlignment18 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

                tableCellProperties19.Append(tableCellWidth19);
                tableCellProperties19.Append(shading19);
                tableCellProperties19.Append(tableCellVerticalAlignment18);

                Paragraph paragraph24 = new Paragraph() { RsidParagraphMarkRevision = "004C1D0B", RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "004C1D0B", RsidRunAdditionDefault = "004C1D0B" };

                ParagraphProperties paragraphProperties22 = new ParagraphProperties();
                FrameProperties frameProperties1 = new FrameProperties() { HorizontalSpace = "141", Wrap = TextWrappingValues.Around, HorizontalPosition = HorizontalAnchorValues.Margin, VerticalPosition = VerticalAnchorValues.Text, Y = "570" };
                SpacingBetweenLines spacingBetweenLines5 = new SpacingBetweenLines() { Before = "40" };
                SuppressOverlap suppressOverlap1 = new SuppressOverlap();

                ParagraphMarkRunProperties paragraphMarkRunProperties21 = new ParagraphMarkRunProperties();
                RunFonts runFonts47 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                FontSize fontSize47 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript47 = new FontSizeComplexScript() { Val = "20" };

                paragraphMarkRunProperties21.Append(runFonts47);
                paragraphMarkRunProperties21.Append(fontSize47);
                paragraphMarkRunProperties21.Append(fontSizeComplexScript47);

                paragraphProperties22.Append(frameProperties1);
                paragraphProperties22.Append(spacingBetweenLines5);
                paragraphProperties22.Append(suppressOverlap1);
                paragraphProperties22.Append(paragraphMarkRunProperties21);

                Run run58 = new Run() { RsidRunProperties = "004C1D0B" };

                RunProperties runProperties58 = new RunProperties();
                RunFonts runFonts48 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                FontSize fontSize48 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript48 = new FontSizeComplexScript() { Val = "20" };

                runProperties58.Append(runFonts48);
                runProperties58.Append(fontSize48);
                runProperties58.Append(fontSizeComplexScript48);
                Text text37 = new Text() { Space = SpaceProcessingModeValues.Preserve };
                text37.Text = ((LanguagesMastery)lang.Fluency).ToString();//"Beginner/ Scholar / Technical / Billingual";

                run58.Append(runProperties58);
                run58.Append(text37);

                paragraph24.Append(paragraphProperties22);
                paragraph24.Append(run58);

                tableCell19.Append(tableCellProperties19);
                tableCell19.Append(paragraph24);

                tableRow6.Append(tableRowProperties6);
                tableRow6.Append(tableCell18);
                tableRow6.Append(tableCell19);

                TableLangues.Append(tableProperties3);
                TableLangues.Append(tableGrid3);
                TableLangues.Append(tableRow6);
            }


            Paragraph paragraph29 = new Paragraph() { RsidParagraphMarkRevision = "006A08FF", RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "00954BC7", RsidRunAdditionDefault = "004C1D0B" };

            ParagraphProperties paragraphProperties27 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties26 = new ParagraphMarkRunProperties();
            RunStyle runStyle1 = new RunStyle() { Val = "Style8ptGrasCouleurpersonnaliseRVB79" };
            RunFonts runFonts66 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Bold bold16 = new Bold() { Val = false };
            BoldComplexScript boldComplexScript1 = new BoldComplexScript() { Val = false };
            Color color30 = new Color() { Val = "000000" };
            FontSize fontSize66 = new FontSize() { Val = "13" };
            Languages languages51 = new Languages() { EastAsia = "fr-FR" };

            paragraphMarkRunProperties26.Append(runStyle1);
            paragraphMarkRunProperties26.Append(runFonts66);
            paragraphMarkRunProperties26.Append(bold16);
            paragraphMarkRunProperties26.Append(boldComplexScript1);
            paragraphMarkRunProperties26.Append(color30);
            paragraphMarkRunProperties26.Append(fontSize66);
            paragraphMarkRunProperties26.Append(languages51);

            paragraphProperties27.Append(paragraphMarkRunProperties26);

            paragraph29.Append(paragraphProperties27);

            tableCell17.Append(tableCellProperties17);
            tableCell17.Append(TableLangues);
            tableCell17.Append(paragraph29);

            #region  Star explained
            TableCell tableCell24 = new TableCell();

            TableCellProperties tableCellProperties24 = new TableCellProperties();
            TableCellWidth tableCellWidth24 = new TableCellWidth() { Width = "5054", Type = TableWidthUnitValues.Dxa };

            tableCellProperties24.Append(tableCellWidth24);

            Paragraph paragraph30 = new Paragraph() { RsidParagraphMarkRevision = "004C1D0B", RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "00954BC7", RsidRunAdditionDefault = "004C1D0B" };

            ParagraphProperties paragraphProperties28 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties27 = new ParagraphMarkRunProperties();
            RunFonts runFonts67 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color31 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize67 = new FontSize() { Val = "21" };
            Languages languages52 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            paragraphMarkRunProperties27.Append(runFonts67);
            paragraphMarkRunProperties27.Append(color31);
            paragraphMarkRunProperties27.Append(fontSize67);
            paragraphMarkRunProperties27.Append(languages52);

            paragraphProperties28.Append(paragraphMarkRunProperties27);

            Run run72 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties72 = new RunProperties();
            RunFonts runFonts68 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color32 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize68 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript66 = new FontSizeComplexScript() { Val = "22" };
            Languages languages53 = new Languages() { EastAsia = "fr-FR" };

            runProperties72.Append(runFonts68);
            runProperties72.Append(color32);
            runProperties72.Append(fontSize68);
            runProperties72.Append(fontSizeComplexScript66);
            runProperties72.Append(languages53);
            SymbolChar symbolChar21 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run72.Append(runProperties72);
            run72.Append(symbolChar21);

            Run run73 = new Run() { RsidRunProperties = "004C1D0B" };

            RunProperties runProperties73 = new RunProperties();
            RunFonts runFonts69 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color33 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize69 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript67 = new FontSizeComplexScript() { Val = "22" };
            Languages languages54 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties73.Append(runFonts69);
            runProperties73.Append(color33);
            runProperties73.Append(fontSize69);
            runProperties73.Append(fontSizeComplexScript67);
            runProperties73.Append(languages54);
            Text text51 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text51.Text = " ";

            run73.Append(runProperties73);
            run73.Append(text51);

            Run run74 = new Run() { RsidRunProperties = "004C1D0B" };

            RunProperties runProperties74 = new RunProperties();
            RunFonts runFonts70 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color34 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize70 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript68 = new FontSizeComplexScript() { Val = "22" };
            Languages languages55 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties74.Append(runFonts70);
            runProperties74.Append(color34);
            runProperties74.Append(fontSize70);
            runProperties74.Append(fontSizeComplexScript68);
            runProperties74.Append(languages55);
            Text text52 = new Text();
            text52.Text = "I have some competences";

            run74.Append(runProperties74);
            run74.Append(text52);

            paragraph30.Append(paragraphProperties28);
            paragraph30.Append(run72);
            paragraph30.Append(run73);
            paragraph30.Append(run74);

            Paragraph paragraph31 = new Paragraph() { RsidParagraphMarkRevision = "004C1D0B", RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "00954BC7", RsidRunAdditionDefault = "004C1D0B" };

            ParagraphProperties paragraphProperties29 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties28 = new ParagraphMarkRunProperties();
            RunFonts runFonts71 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Italic italic31 = new Italic();
            Color color35 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize71 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript69 = new FontSizeComplexScript() { Val = "22" };
            Languages languages56 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            paragraphMarkRunProperties28.Append(runFonts71);
            paragraphMarkRunProperties28.Append(italic31);
            paragraphMarkRunProperties28.Append(color35);
            paragraphMarkRunProperties28.Append(fontSize71);
            paragraphMarkRunProperties28.Append(fontSizeComplexScript69);
            paragraphMarkRunProperties28.Append(languages56);

            paragraphProperties29.Append(paragraphMarkRunProperties28);

            Run run75 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties75 = new RunProperties();
            RunFonts runFonts72 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color36 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize72 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript70 = new FontSizeComplexScript() { Val = "22" };
            Languages languages57 = new Languages() { EastAsia = "fr-FR" };

            runProperties75.Append(runFonts72);
            runProperties75.Append(color36);
            runProperties75.Append(fontSize72);
            runProperties75.Append(fontSizeComplexScript70);
            runProperties75.Append(languages57);
            SymbolChar symbolChar22 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run75.Append(runProperties75);
            run75.Append(symbolChar22);

            Run run76 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties76 = new RunProperties();
            RunFonts runFonts73 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color37 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize73 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript71 = new FontSizeComplexScript() { Val = "22" };
            Languages languages58 = new Languages() { EastAsia = "fr-FR" };

            runProperties76.Append(runFonts73);
            runProperties76.Append(color37);
            runProperties76.Append(fontSize73);
            runProperties76.Append(fontSizeComplexScript71);
            runProperties76.Append(languages58);
            SymbolChar symbolChar23 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run76.Append(runProperties76);
            run76.Append(symbolChar23);

            Run run77 = new Run() { RsidRunProperties = "004C1D0B" };

            RunProperties runProperties77 = new RunProperties();
            RunFonts runFonts74 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color38 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize74 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript72 = new FontSizeComplexScript() { Val = "22" };
            Languages languages59 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties77.Append(runFonts74);
            runProperties77.Append(color38);
            runProperties77.Append(fontSize74);
            runProperties77.Append(fontSizeComplexScript72);
            runProperties77.Append(languages59);
            Text text53 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text53.Text = " ";

            run77.Append(runProperties77);
            run77.Append(text53);

            Run run78 = new Run() { RsidRunProperties = "004C1D0B" };

            RunProperties runProperties78 = new RunProperties();
            RunFonts runFonts75 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color39 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize75 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript73 = new FontSizeComplexScript() { Val = "22" };
            Languages languages60 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties78.Append(runFonts75);
            runProperties78.Append(color39);
            runProperties78.Append(fontSize75);
            runProperties78.Append(fontSizeComplexScript73);
            runProperties78.Append(languages60);
            Text text54 = new Text();
            text54.Text = "I know how to do but I need support";

            run78.Append(runProperties78);
            run78.Append(text54);

            paragraph31.Append(paragraphProperties29);
            paragraph31.Append(run75);
            paragraph31.Append(run76);
            paragraph31.Append(run77);
            paragraph31.Append(run78);

            Paragraph paragraph32 = new Paragraph() { RsidParagraphMarkRevision = "006051D6", RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "00954BC7", RsidRunAdditionDefault = "004C1D0B" };

            ParagraphProperties paragraphProperties30 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties29 = new ParagraphMarkRunProperties();
            RunFonts runFonts76 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color40 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize76 = new FontSize() { Val = "21" };
            Languages languages61 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            paragraphMarkRunProperties29.Append(runFonts76);
            paragraphMarkRunProperties29.Append(color40);
            paragraphMarkRunProperties29.Append(fontSize76);
            paragraphMarkRunProperties29.Append(languages61);

            paragraphProperties30.Append(paragraphMarkRunProperties29);

            Run run79 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties79 = new RunProperties();
            RunFonts runFonts77 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color41 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize77 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript74 = new FontSizeComplexScript() { Val = "22" };
            Languages languages62 = new Languages() { EastAsia = "fr-FR" };

            runProperties79.Append(runFonts77);
            runProperties79.Append(color41);
            runProperties79.Append(fontSize77);
            runProperties79.Append(fontSizeComplexScript74);
            runProperties79.Append(languages62);
            SymbolChar symbolChar24 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run79.Append(runProperties79);
            run79.Append(symbolChar24);

            Run run80 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties80 = new RunProperties();
            RunFonts runFonts78 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color42 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize78 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript75 = new FontSizeComplexScript() { Val = "22" };
            Languages languages63 = new Languages() { EastAsia = "fr-FR" };

            runProperties80.Append(runFonts78);
            runProperties80.Append(color42);
            runProperties80.Append(fontSize78);
            runProperties80.Append(fontSizeComplexScript75);
            runProperties80.Append(languages63);
            SymbolChar symbolChar25 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run80.Append(runProperties80);
            run80.Append(symbolChar25);

            Run run81 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties81 = new RunProperties();
            RunFonts runFonts79 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color43 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize79 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript76 = new FontSizeComplexScript() { Val = "22" };
            Languages languages64 = new Languages() { EastAsia = "fr-FR" };

            runProperties81.Append(runFonts79);
            runProperties81.Append(color43);
            runProperties81.Append(fontSize79);
            runProperties81.Append(fontSizeComplexScript76);
            runProperties81.Append(languages64);
            SymbolChar symbolChar26 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run81.Append(runProperties81);
            run81.Append(symbolChar26);

            Run run82 = new Run() { RsidRunProperties = "006051D6" };

            RunProperties runProperties82 = new RunProperties();
            RunFonts runFonts80 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color44 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize80 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript77 = new FontSizeComplexScript() { Val = "22" };
            Languages languages65 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties82.Append(runFonts80);
            runProperties82.Append(color44);
            runProperties82.Append(fontSize80);
            runProperties82.Append(fontSizeComplexScript77);
            runProperties82.Append(languages65);
            Text text55 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text55.Text = "  ";

            run82.Append(runProperties82);
            run82.Append(text55);

            Run run83 = new Run() { RsidRunProperties = "006051D6" };

            RunProperties runProperties83 = new RunProperties();
            RunFonts runFonts81 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color45 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize81 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript78 = new FontSizeComplexScript() { Val = "22" };
            Languages languages66 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties83.Append(runFonts81);
            runProperties83.Append(color45);
            runProperties83.Append(fontSize81);
            runProperties83.Append(fontSizeComplexScript78);
            runProperties83.Append(languages66);
            Text text56 = new Text();
            text56.Text = "Good level";

            run83.Append(runProperties83);
            run83.Append(text56);

            paragraph32.Append(paragraphProperties30);
            paragraph32.Append(run79);
            paragraph32.Append(run80);
            paragraph32.Append(run81);
            paragraph32.Append(run82);
            paragraph32.Append(run83);

            Paragraph paragraph33 = new Paragraph() { RsidParagraphMarkRevision = "004C1D0B", RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "00954BC7", RsidRunAdditionDefault = "004C1D0B" };

            ParagraphProperties paragraphProperties31 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties30 = new ParagraphMarkRunProperties();
            RunFonts runFonts82 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color46 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize82 = new FontSize() { Val = "21" };
            Languages languages67 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            paragraphMarkRunProperties30.Append(runFonts82);
            paragraphMarkRunProperties30.Append(color46);
            paragraphMarkRunProperties30.Append(fontSize82);
            paragraphMarkRunProperties30.Append(languages67);

            paragraphProperties31.Append(paragraphMarkRunProperties30);

            Run run84 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties84 = new RunProperties();
            RunFonts runFonts83 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color47 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize83 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript79 = new FontSizeComplexScript() { Val = "22" };
            Languages languages68 = new Languages() { EastAsia = "fr-FR" };

            runProperties84.Append(runFonts83);
            runProperties84.Append(color47);
            runProperties84.Append(fontSize83);
            runProperties84.Append(fontSizeComplexScript79);
            runProperties84.Append(languages68);
            SymbolChar symbolChar27 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run84.Append(runProperties84);
            run84.Append(symbolChar27);

            Run run85 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties85 = new RunProperties();
            RunFonts runFonts84 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color48 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize84 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript80 = new FontSizeComplexScript() { Val = "22" };
            Languages languages69 = new Languages() { EastAsia = "fr-FR" };

            runProperties85.Append(runFonts84);
            runProperties85.Append(color48);
            runProperties85.Append(fontSize84);
            runProperties85.Append(fontSizeComplexScript80);
            runProperties85.Append(languages69);
            SymbolChar symbolChar28 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run85.Append(runProperties85);
            run85.Append(symbolChar28);

            Run run86 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties86 = new RunProperties();
            RunFonts runFonts85 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color49 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize85 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript81 = new FontSizeComplexScript() { Val = "22" };
            Languages languages70 = new Languages() { EastAsia = "fr-FR" };

            runProperties86.Append(runFonts85);
            runProperties86.Append(color49);
            runProperties86.Append(fontSize85);
            runProperties86.Append(fontSizeComplexScript81);
            runProperties86.Append(languages70);
            SymbolChar symbolChar29 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run86.Append(runProperties86);
            run86.Append(symbolChar29);

            Run run87 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties87 = new RunProperties();
            RunFonts runFonts86 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color50 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize86 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript82 = new FontSizeComplexScript() { Val = "22" };
            Languages languages71 = new Languages() { EastAsia = "fr-FR" };

            runProperties87.Append(runFonts86);
            runProperties87.Append(color50);
            runProperties87.Append(fontSize86);
            runProperties87.Append(fontSizeComplexScript82);
            runProperties87.Append(languages71);
            SymbolChar symbolChar30 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run87.Append(runProperties87);
            run87.Append(symbolChar30);

            Run run88 = new Run() { RsidRunProperties = "004C1D0B" };

            RunProperties runProperties88 = new RunProperties();
            RunFonts runFonts87 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color51 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize87 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript83 = new FontSizeComplexScript() { Val = "22" };
            Languages languages72 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties88.Append(runFonts87);
            runProperties88.Append(color51);
            runProperties88.Append(fontSize87);
            runProperties88.Append(fontSizeComplexScript83);
            runProperties88.Append(languages72);
            Text text57 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text57.Text = "  ";

            run88.Append(runProperties88);
            run88.Append(text57);

            Run run89 = new Run() { RsidRunProperties = "004C1D0B" };

            RunProperties runProperties89 = new RunProperties();
            RunFonts runFonts88 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color52 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize88 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript84 = new FontSizeComplexScript() { Val = "22" };
            Languages languages73 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties89.Append(runFonts88);
            runProperties89.Append(color52);
            runProperties89.Append(fontSize88);
            runProperties89.Append(fontSizeComplexScript84);
            runProperties89.Append(languages73);
            Text text58 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text58.Text = "Very good level / ";

            run89.Append(runProperties89);
            run89.Append(text58);

            Run run90 = new Run();

            RunProperties runProperties90 = new RunProperties();
            RunFonts runFonts89 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color53 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize89 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript85 = new FontSizeComplexScript() { Val = "22" };
            Languages languages74 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties90.Append(runFonts89);
            runProperties90.Append(color53);
            runProperties90.Append(fontSize89);
            runProperties90.Append(fontSizeComplexScript85);
            runProperties90.Append(languages74);
            Text text59 = new Text();
            text59.Text = "mastering the topic";

            run90.Append(runProperties90);
            run90.Append(text59);

            paragraph33.Append(paragraphProperties31);
            paragraph33.Append(run84);
            paragraph33.Append(run85);
            paragraph33.Append(run86);
            paragraph33.Append(run87);
            paragraph33.Append(run88);
            paragraph33.Append(run89);
            paragraph33.Append(run90);

            Paragraph paragraph34 = new Paragraph() { RsidParagraphMarkRevision = "004C1D0B", RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "00954BC7", RsidRunAdditionDefault = "004C1D0B" };

            ParagraphProperties paragraphProperties32 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties31 = new ParagraphMarkRunProperties();
            RunFonts runFonts90 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color54 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize90 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript86 = new FontSizeComplexScript() { Val = "22" };
            Languages languages75 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            paragraphMarkRunProperties31.Append(runFonts90);
            paragraphMarkRunProperties31.Append(color54);
            paragraphMarkRunProperties31.Append(fontSize90);
            paragraphMarkRunProperties31.Append(fontSizeComplexScript86);
            paragraphMarkRunProperties31.Append(languages75);

            paragraphProperties32.Append(paragraphMarkRunProperties31);

            Run run91 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties91 = new RunProperties();
            RunFonts runFonts91 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color55 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize91 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript87 = new FontSizeComplexScript() { Val = "22" };
            Languages languages76 = new Languages() { EastAsia = "fr-FR" };

            runProperties91.Append(runFonts91);
            runProperties91.Append(color55);
            runProperties91.Append(fontSize91);
            runProperties91.Append(fontSizeComplexScript87);
            runProperties91.Append(languages76);
            SymbolChar symbolChar31 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run91.Append(runProperties91);
            run91.Append(symbolChar31);

            Run run92 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties92 = new RunProperties();
            RunFonts runFonts92 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color56 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize92 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript88 = new FontSizeComplexScript() { Val = "22" };
            Languages languages77 = new Languages() { EastAsia = "fr-FR" };

            runProperties92.Append(runFonts92);
            runProperties92.Append(color56);
            runProperties92.Append(fontSize92);
            runProperties92.Append(fontSizeComplexScript88);
            runProperties92.Append(languages77);
            SymbolChar symbolChar32 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run92.Append(runProperties92);
            run92.Append(symbolChar32);

            Run run93 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties93 = new RunProperties();
            RunFonts runFonts93 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color57 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize93 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript89 = new FontSizeComplexScript() { Val = "22" };
            Languages languages78 = new Languages() { EastAsia = "fr-FR" };

            runProperties93.Append(runFonts93);
            runProperties93.Append(color57);
            runProperties93.Append(fontSize93);
            runProperties93.Append(fontSizeComplexScript89);
            runProperties93.Append(languages78);
            SymbolChar symbolChar33 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run93.Append(runProperties93);
            run93.Append(symbolChar33);

            Run run94 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties94 = new RunProperties();
            RunFonts runFonts94 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color58 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize94 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript90 = new FontSizeComplexScript() { Val = "22" };
            Languages languages79 = new Languages() { EastAsia = "fr-FR" };

            runProperties94.Append(runFonts94);
            runProperties94.Append(color58);
            runProperties94.Append(fontSize94);
            runProperties94.Append(fontSizeComplexScript90);
            runProperties94.Append(languages79);
            SymbolChar symbolChar34 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run94.Append(runProperties94);
            run94.Append(symbolChar34);

            Run run95 = new Run() { RsidRunProperties = "007E32C1" };

            RunProperties runProperties95 = new RunProperties();
            RunFonts runFonts95 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color59 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize95 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript91 = new FontSizeComplexScript() { Val = "22" };
            Languages languages80 = new Languages() { EastAsia = "fr-FR" };

            runProperties95.Append(runFonts95);
            runProperties95.Append(color59);
            runProperties95.Append(fontSize95);
            runProperties95.Append(fontSizeComplexScript91);
            runProperties95.Append(languages80);
            SymbolChar symbolChar35 = new SymbolChar() { Font = "Wingdings", Char = "F0AB" };

            run95.Append(runProperties95);
            run95.Append(symbolChar35);

            Run run96 = new Run() { RsidRunProperties = "004C1D0B" };

            RunProperties runProperties96 = new RunProperties();
            RunFonts runFonts96 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color60 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize96 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript92 = new FontSizeComplexScript() { Val = "22" };
            Languages languages81 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties96.Append(runFonts96);
            runProperties96.Append(color60);
            runProperties96.Append(fontSize96);
            runProperties96.Append(fontSizeComplexScript92);
            runProperties96.Append(languages81);
            Text text60 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text60.Text = " ";

            run96.Append(runProperties96);
            run96.Append(text60);

            Run run97 = new Run() { RsidRunProperties = "004C1D0B" };

            RunProperties runProperties97 = new RunProperties();
            RunFonts runFonts97 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Color color61 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize97 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript93 = new FontSizeComplexScript() { Val = "22" };
            Languages languages82 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            runProperties97.Append(runFonts97);
            runProperties97.Append(color61);
            runProperties97.Append(fontSize97);
            runProperties97.Append(fontSizeComplexScript93);
            runProperties97.Append(languages82);
            Text text61 = new Text();
            text61.Text = "Subject Matter Expert";

            run97.Append(runProperties97);
            run97.Append(text61);

            paragraph34.Append(paragraphProperties32);
            paragraph34.Append(run91);
            paragraph34.Append(run92);
            paragraph34.Append(run93);
            paragraph34.Append(run94);
            paragraph34.Append(run95);
            paragraph34.Append(run96);
            paragraph34.Append(run97);

            Paragraph paragraph35 = new Paragraph() { RsidParagraphMarkRevision = "004C1D0B", RsidParagraphAddition = "004C1D0B", RsidParagraphProperties = "00954BC7", RsidRunAdditionDefault = "004C1D0B" };

            ParagraphProperties paragraphProperties33 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties32 = new ParagraphMarkRunProperties();
            RunStyle runStyle2 = new RunStyle() { Val = "Style8ptGrasCouleurpersonnaliseRVB79" };
            RunFonts runFonts98 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
            Bold bold17 = new Bold() { Val = false };
            BoldComplexScript boldComplexScript2 = new BoldComplexScript() { Val = false };
            Color color62 = new Color() { Val = "767171", ThemeColor = ThemeColorValues.Background2, ThemeShade = "80" };
            FontSize fontSize98 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript94 = new FontSizeComplexScript() { Val = "22" };
            Languages languages83 = new Languages() { Val = "en-GB", EastAsia = "fr-FR" };

            paragraphMarkRunProperties32.Append(runStyle2);
            paragraphMarkRunProperties32.Append(runFonts98);
            paragraphMarkRunProperties32.Append(bold17);
            paragraphMarkRunProperties32.Append(boldComplexScript2);
            paragraphMarkRunProperties32.Append(color62);
            paragraphMarkRunProperties32.Append(fontSize98);
            paragraphMarkRunProperties32.Append(fontSizeComplexScript94);
            paragraphMarkRunProperties32.Append(languages83);

            paragraphProperties33.Append(paragraphMarkRunProperties32);

            paragraph35.Append(paragraphProperties33);

            tableCell24.Append(tableCellProperties24);
            tableCell24.Append(paragraph30);
            tableCell24.Append(paragraph31);
            tableCell24.Append(paragraph32);
            tableCell24.Append(paragraph33);
            tableCell24.Append(paragraph34);
            tableCell24.Append(paragraph35);

            tableRow5.Append(tableRowProperties5);
            tableRow5.Append(tableCell17);
            tableRow5.Append(tableCell24);

            table2.Append(tableProperties2);
            table2.Append(tableGrid2);
            table2.Append(tableRow5);
            #endregion
            Paragraph paragraph36 = new Paragraph() { RsidParagraphMarkRevision = "006B4E5C", RsidParagraphAddition = "006B4E5C", RsidParagraphProperties = "006B4E5C", RsidRunAdditionDefault = "006B4E5C" };

            ParagraphProperties paragraphProperties34 = new ParagraphProperties();
            Indentation indentation4 = new Indentation() { FirstLine = "720" };

            ParagraphMarkRunProperties paragraphMarkRunProperties33 = new ParagraphMarkRunProperties();
            FontSize fontSize99 = new FontSize() { Val = "2" };
            FontSizeComplexScript fontSizeComplexScript95 = new FontSizeComplexScript() { Val = "2" };

            paragraphMarkRunProperties33.Append(fontSize99);
            paragraphMarkRunProperties33.Append(fontSizeComplexScript95);

            paragraphProperties34.Append(indentation4);
            paragraphProperties34.Append(paragraphMarkRunProperties33);

            paragraph36.Append(paragraphProperties34);

            Paragraph EducationTitle = new Paragraph() { RsidParagraphAddition = "00956190", RsidRunAdditionDefault = "003E0279" };

            Run run98 = new Run();

            RunProperties runProperties98 = new RunProperties();
            NoProof noProof2 = new NoProof();

            runProperties98.Append(noProof2);

            Drawing drawing2 = new Drawing();

            Wp.Anchor anchor2 = new Wp.Anchor() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)114300U, DistanceFromRight = (UInt32Value)114300U, SimplePos = false, RelativeHeight = (UInt32Value)251659264U, BehindDoc = false, Locked = false, LayoutInCell = true, AllowOverlap = true };
            Wp.SimplePosition simplePosition2 = new Wp.SimplePosition() { X = 0L, Y = 0L };

            Wp.HorizontalPosition horizontalPosition2 = new Wp.HorizontalPosition() { RelativeFrom = Wp.HorizontalRelativePositionValues.Column };
            Wp.PositionOffset positionOffset3 = new Wp.PositionOffset();
            positionOffset3.Text = "-692150";

            horizontalPosition2.Append(positionOffset3);

            Wp.VerticalPosition verticalPosition2 = new Wp.VerticalPosition() { RelativeFrom = Wp.VerticalRelativePositionValues.Paragraph };
            Wp.PositionOffset positionOffset4 = new Wp.PositionOffset();
            positionOffset4.Text = "125730";

            verticalPosition2.Append(positionOffset4);
            Wp.Extent extent2 = new Wp.Extent() { Cx = 7160400L, Cy = 431739L };
            Wp.EffectExtent effectExtent2 = new Wp.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 635L };
            Wp.WrapNone wrapNone2 = new Wp.WrapNone();
            Wp.DocProperties docProperties2 = new Wp.DocProperties() { Id = (UInt32Value)6U, Name = "Image 6" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties2 = new Wp.NonVisualGraphicFrameDrawingProperties();

            A.GraphicFrameLocks graphicFrameLocks2 = new A.GraphicFrameLocks() { NoChangeAspect = true };
            graphicFrameLocks2.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            nonVisualGraphicFrameDrawingProperties2.Append(graphicFrameLocks2);

            A.Graphic graphic2 = new A.Graphic();
            graphic2.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData2 = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture2 = new Pic.Picture();
            picture2.AddNamespaceDeclaration("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture");

            Pic.NonVisualPictureProperties nonVisualPictureProperties2 = new Pic.NonVisualPictureProperties();
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties2 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)6U, Name = "EDUCATION.png" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties2 = new Pic.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties2.Append(nonVisualDrawingProperties2);
            nonVisualPictureProperties2.Append(nonVisualPictureDrawingProperties2);

            Pic.BlipFill blipFill2 = new Pic.BlipFill();

            A.Blip blip2 = new A.Blip() { Embed = "rId9", CompressionState = A.BlipCompressionValues.Print };

            A.BlipExtensionList blipExtensionList2 = new A.BlipExtensionList();

            A.BlipExtension blipExtension2 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi2 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi2.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension2.Append(useLocalDpi2);

            blipExtensionList2.Append(blipExtension2);

            blip2.Append(blipExtensionList2);

            A.Stretch stretch2 = new A.Stretch();
            A.FillRectangle fillRectangle2 = new A.FillRectangle();

            stretch2.Append(fillRectangle2);

            blipFill2.Append(blip2);
            blipFill2.Append(stretch2);

            Pic.ShapeProperties shapeProperties2 = new Pic.ShapeProperties();

            A.Transform2D transform2D2 = new A.Transform2D();
            A.Offset offset2 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents2 = new A.Extents() { Cx = 7160400L, Cy = 431739L };

            transform2D2.Append(offset2);
            transform2D2.Append(extents2);

            A.PresetGeometry presetGeometry2 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList2 = new A.AdjustValueList();

            presetGeometry2.Append(adjustValueList2);

            shapeProperties2.Append(transform2D2);
            shapeProperties2.Append(presetGeometry2);

            picture2.Append(nonVisualPictureProperties2);
            picture2.Append(blipFill2);
            picture2.Append(shapeProperties2);

            graphicData2.Append(picture2);

            graphic2.Append(graphicData2);

            Wp14.RelativeWidth relativeWidth2 = new Wp14.RelativeWidth() { ObjectId = Wp14.SizeRelativeHorizontallyValues.Page };
            Wp14.PercentageWidth percentageWidth2 = new Wp14.PercentageWidth();
            percentageWidth2.Text = "0";

            relativeWidth2.Append(percentageWidth2);

            Wp14.RelativeHeight relativeHeight2 = new Wp14.RelativeHeight() { RelativeFrom = Wp14.SizeRelativeVerticallyValues.Page };
            Wp14.PercentageHeight percentageHeight2 = new Wp14.PercentageHeight();
            percentageHeight2.Text = "0";

            relativeHeight2.Append(percentageHeight2);

            anchor2.Append(simplePosition2);
            anchor2.Append(horizontalPosition2);
            anchor2.Append(verticalPosition2);
            anchor2.Append(extent2);
            anchor2.Append(effectExtent2);
            anchor2.Append(wrapNone2);
            anchor2.Append(docProperties2);
            anchor2.Append(nonVisualGraphicFrameDrawingProperties2);
            anchor2.Append(graphic2);
            anchor2.Append(relativeWidth2);
            anchor2.Append(relativeHeight2);

            drawing2.Append(anchor2);

            run98.Append(runProperties98);
            run98.Append(drawing2);

            EducationTitle.Append(run98);

            Paragraph paragraph38 = new Paragraph() { RsidParagraphAddition = "00985748", RsidParagraphProperties = "00132EE5", RsidRunAdditionDefault = "00985748" };

            ParagraphProperties paragraphProperties35 = new ParagraphProperties();

            Tabs tabs4 = new Tabs();
            TabStop tabStop4 = new TabStop() { Val = TabStopValues.Left, Position = 1701 };

            tabs4.Append(tabStop4);

            ParagraphMarkRunProperties paragraphMarkRunProperties34 = new ParagraphMarkRunProperties();
            RunFonts runFonts99 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            FontSize fontSize100 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript96 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties34.Append(runFonts99);
            paragraphMarkRunProperties34.Append(fontSize100);
            paragraphMarkRunProperties34.Append(fontSizeComplexScript96);

            paragraphProperties35.Append(tabs4);
            paragraphProperties35.Append(paragraphMarkRunProperties34);

            paragraph38.Append(paragraphProperties35);

            #region Education
            Paragraph paragraph39 = new Paragraph() { RsidParagraphMarkRevision = "006A08FF", RsidParagraphAddition = "00985748", RsidParagraphProperties = "00190E66", RsidRunAdditionDefault = "00132EE5" };
            ParagraphProperties paragraphProperties36 = new ParagraphProperties();
            foreach (var edu in _Konsultant.PersonalEducation.OrderBy(p => p.StartDate))
            {
                ParagraphMarkRunProperties paragraphMarkRunProperties35 = new ParagraphMarkRunProperties();
                RunFonts runFonts100 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize101 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript97 = new FontSizeComplexScript() { Val = "20" };

                paragraphMarkRunProperties35.Append(runFonts100);
                paragraphMarkRunProperties35.Append(fontSize101);
                paragraphMarkRunProperties35.Append(fontSizeComplexScript97);
                Tabs tabs5 = new Tabs();
                TabStop tabStop5 = new TabStop() { Val = TabStopValues.Left, Position = 8220 };

                tabs5.Append(tabStop5);
                paragraphProperties36.Append(tabs5);
                paragraphProperties36.Append(paragraphMarkRunProperties35);

                Run run99 = new Run() { RsidRunProperties = "006A08FF" };

                RunProperties runProperties99 = new RunProperties();
                RunFonts runFonts101 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize102 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript98 = new FontSizeComplexScript() { Val = "20" };

                runProperties99.Append(runFonts101);
                runProperties99.Append(fontSize102);
                runProperties99.Append(fontSizeComplexScript98);
                Text text62 = new Text();
                text62.Text = $"{edu.StartDate.ToShortDateString()} - {edu.EndDate.ToShortDateString()} : {edu.Education.Name}";

                run99.Append(runProperties99);
                run99.Append(text62);
                run99.AppendChild(new Break());
                paragraph39.Append(run99);

            }


            //Run run100 = new Run() { RsidRunAddition = "00190E66" };

            //RunProperties runProperties100 = new RunProperties();
            //RunFonts runFonts102 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            //FontSize fontSize103 = new FontSize() { Val = "20" };
            //FontSizeComplexScript fontSizeComplexScript99 = new FontSizeComplexScript() { Val = "20" };

            //runProperties100.Append(runFonts102);
            //runProperties100.Append(fontSize103);
            //runProperties100.Append(fontSizeComplexScript99);
            //TabChar tabChar1 = new TabChar();

            //run100.Append(runProperties100);
            //run100.Append(tabChar1);

            //paragraph39.Append(paragraphProperties36);
            //paragraph39.Append(run99);
            //paragraph39.Append(run100);

            //Paragraph paragraph40 = new Paragraph() { RsidParagraphAddition = "00985748", RsidParagraphProperties = "004C1D0B", RsidRunAdditionDefault = "00985748" };

            //ParagraphProperties paragraphProperties37 = new ParagraphProperties();

            //ParagraphMarkRunProperties paragraphMarkRunProperties36 = new ParagraphMarkRunProperties();
            //RunFonts runFonts103 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            //FontSize fontSize104 = new FontSize() { Val = "20" };
            //FontSizeComplexScript fontSizeComplexScript100 = new FontSizeComplexScript() { Val = "20" };

            //paragraphMarkRunProperties36.Append(runFonts103);
            //paragraphMarkRunProperties36.Append(fontSize104);
            //paragraphMarkRunProperties36.Append(fontSizeComplexScript100);

            //paragraphProperties37.Append(paragraphMarkRunProperties36);

            //Run run101 = new Run();

            //RunProperties runProperties101 = new RunProperties();
            //RunFonts runFonts104 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            //FontSize fontSize105 = new FontSize() { Val = "20" };
            //FontSizeComplexScript fontSizeComplexScript101 = new FontSizeComplexScript() { Val = "20" };

            //runProperties101.Append(runFonts104);
            //runProperties101.Append(fontSize105);
            //runProperties101.Append(fontSizeComplexScript101);
            //Text text63 = new Text();
            //text63.Text = "20XX";

            //run101.Append(runProperties101);
            //run101.Append(text63);

            //paragraph40.Append(paragraphProperties37);
            //paragraph40.Append(run101);

            //Paragraph paragraph41 = new Paragraph() { RsidParagraphAddition = "006B4E5C", RsidParagraphProperties = "006B4E5C", RsidRunAdditionDefault = "00985748" };

            //ParagraphProperties paragraphProperties38 = new ParagraphProperties();

            //ParagraphMarkRunProperties paragraphMarkRunProperties37 = new ParagraphMarkRunProperties();
            //RunFonts runFonts105 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            //FontSize fontSize106 = new FontSize() { Val = "20" };
            //FontSizeComplexScript fontSizeComplexScript102 = new FontSizeComplexScript() { Val = "20" };

            //paragraphMarkRunProperties37.Append(runFonts105);
            //paragraphMarkRunProperties37.Append(fontSize106);
            //paragraphMarkRunProperties37.Append(fontSizeComplexScript102);

            //paragraphProperties38.Append(paragraphMarkRunProperties37);
            #endregion

            Run run102 = new Run();
            Paragraph ClearencesPara = new Paragraph() { RsidParagraphAddition = "00985748", RsidParagraphProperties = "00132EE5", RsidRunAdditionDefault = "00985748" };
            Paragraph ClearencesParaText = new Paragraph() { RsidParagraphAddition = "00985748", RsidParagraphProperties = "00132EE5", RsidRunAdditionDefault = "00985748" };

            RunProperties runProperties102 = new RunProperties();
            NoProof noProof3 = new NoProof();

            runProperties102.Append(noProof3);

            Drawing drawing3 = new Drawing();

            Wp.Anchor anchor3 = new Wp.Anchor() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)114300U, DistanceFromRight = (UInt32Value)114300U, SimplePos = false, RelativeHeight = (UInt32Value)251664384U, BehindDoc = true, Locked = false, LayoutInCell = true, AllowOverlap = true, AnchorId = "225096D6" };
            Wp.SimplePosition simplePosition3 = new Wp.SimplePosition() { X = 0L, Y = 0L };

            Wp.HorizontalPosition horizontalPosition3 = new Wp.HorizontalPosition() { RelativeFrom = Wp.HorizontalRelativePositionValues.Column };
            Wp.PositionOffset positionOffset5 = new Wp.PositionOffset();
            positionOffset5.Text = "-694055";

            horizontalPosition3.Append(positionOffset5);

            Wp.VerticalPosition verticalPosition3 = new Wp.VerticalPosition() { RelativeFrom = Wp.VerticalRelativePositionValues.Paragraph };
            Wp.PositionOffset positionOffset6 = new Wp.PositionOffset();
            positionOffset6.Text = "165100";

            verticalPosition3.Append(positionOffset6);
            Wp.Extent extent3 = new Wp.Extent() { Cx = 7160400L, Cy = 432000L };
            Wp.EffectExtent effectExtent3 = new Wp.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 2540L, BottomEdge = 0L };

            Wp.WrapTight wrapTight1 = new Wp.WrapTight() { WrapText = Wp.WrapTextValues.BothSides };

            Wp.WrapPolygon wrapPolygon1 = new Wp.WrapPolygon() { Edited = false };
            Wp.StartPoint startPoint1 = new Wp.StartPoint() { X = 460L, Y = 0L };
            Wp.LineTo lineTo1 = new Wp.LineTo() { X = 230L, Y = 2541L };
            Wp.LineTo lineTo2 = new Wp.LineTo() { X = 0L, Y = 8259L };
            Wp.LineTo lineTo3 = new Wp.LineTo() { X = 0L, Y = 12706L };
            Wp.LineTo lineTo4 = new Wp.LineTo() { X = 306L, Y = 20329L };
            Wp.LineTo lineTo5 = new Wp.LineTo() { X = 498L, Y = 20965L };
            Wp.LineTo lineTo6 = new Wp.LineTo() { X = 1034L, Y = 20965L };
            Wp.LineTo lineTo7 = new Wp.LineTo() { X = 13294L, Y = 20329L };
            Wp.LineTo lineTo8 = new Wp.LineTo() { X = 21569L, Y = 16518L };
            Wp.LineTo lineTo9 = new Wp.LineTo() { X = 21569L, Y = 4447L };
            Wp.LineTo lineTo10 = new Wp.LineTo() { X = 20458L, Y = 4447L };
            Wp.LineTo lineTo11 = new Wp.LineTo() { X = 1034L, Y = 0L };
            Wp.LineTo lineTo12 = new Wp.LineTo() { X = 460L, Y = 0L };

            wrapPolygon1.Append(startPoint1);
            wrapPolygon1.Append(lineTo1);
            wrapPolygon1.Append(lineTo2);
            wrapPolygon1.Append(lineTo3);
            wrapPolygon1.Append(lineTo4);
            wrapPolygon1.Append(lineTo5);
            wrapPolygon1.Append(lineTo6);
            wrapPolygon1.Append(lineTo7);
            wrapPolygon1.Append(lineTo8);
            wrapPolygon1.Append(lineTo9);
            wrapPolygon1.Append(lineTo10);
            wrapPolygon1.Append(lineTo11);
            wrapPolygon1.Append(lineTo12);

            wrapTight1.Append(wrapPolygon1);
            Wp.DocProperties docProperties3 = new Wp.DocProperties() { Id = (UInt32Value)7U, Name = "Image 7" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties3 = new Wp.NonVisualGraphicFrameDrawingProperties();

            A.GraphicFrameLocks graphicFrameLocks3 = new A.GraphicFrameLocks() { NoChangeAspect = true };
            graphicFrameLocks3.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            nonVisualGraphicFrameDrawingProperties3.Append(graphicFrameLocks3);

            A.Graphic graphic3 = new A.Graphic();
            graphic3.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData3 = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture3 = new Pic.Picture();
            picture3.AddNamespaceDeclaration("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture");

            Pic.NonVisualPictureProperties nonVisualPictureProperties3 = new Pic.NonVisualPictureProperties();
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties3 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)7U, Name = "CERTIFICATES_CLEARANCE.png" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties3 = new Pic.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties3.Append(nonVisualDrawingProperties3);
            nonVisualPictureProperties3.Append(nonVisualPictureDrawingProperties3);

            Pic.BlipFill blipFill3 = new Pic.BlipFill();

            A.Blip blip3 = new A.Blip() { Embed = "rId10", CompressionState = A.BlipCompressionValues.Print };

            A.BlipExtensionList blipExtensionList3 = new A.BlipExtensionList();

            A.BlipExtension blipExtension3 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi3 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi3.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension3.Append(useLocalDpi3);

            blipExtensionList3.Append(blipExtension3);

            blip3.Append(blipExtensionList3);

            A.Stretch stretch3 = new A.Stretch();
            A.FillRectangle fillRectangle3 = new A.FillRectangle();

            stretch3.Append(fillRectangle3);

            blipFill3.Append(blip3);
            blipFill3.Append(stretch3);

            Pic.ShapeProperties shapeProperties3 = new Pic.ShapeProperties();

            A.Transform2D transform2D3 = new A.Transform2D();
            A.Offset offset3 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents3 = new A.Extents() { Cx = 7160400L, Cy = 432000L };

            transform2D3.Append(offset3);
            transform2D3.Append(extents3);

            A.PresetGeometry presetGeometry3 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList3 = new A.AdjustValueList();

            presetGeometry3.Append(adjustValueList3);

            shapeProperties3.Append(transform2D3);
            shapeProperties3.Append(presetGeometry3);

            picture3.Append(nonVisualPictureProperties3);
            picture3.Append(blipFill3);
            picture3.Append(shapeProperties3);

            graphicData3.Append(picture3);

            graphic3.Append(graphicData3);

            Wp14.RelativeWidth relativeWidth3 = new Wp14.RelativeWidth() { ObjectId = Wp14.SizeRelativeHorizontallyValues.Margin };
            Wp14.PercentageWidth percentageWidth3 = new Wp14.PercentageWidth();
            percentageWidth3.Text = "0";

            relativeWidth3.Append(percentageWidth3);

            Wp14.RelativeHeight relativeHeight3 = new Wp14.RelativeHeight() { RelativeFrom = Wp14.SizeRelativeVerticallyValues.Margin };
            Wp14.PercentageHeight percentageHeight3 = new Wp14.PercentageHeight();
            percentageHeight3.Text = "0";

            relativeHeight3.Append(percentageHeight3);

            anchor3.Append(simplePosition3);
            anchor3.Append(horizontalPosition3);
            anchor3.Append(verticalPosition3);
            anchor3.Append(extent3);
            anchor3.Append(effectExtent3);
            anchor3.Append(wrapTight1);
            anchor3.Append(docProperties3);
            anchor3.Append(nonVisualGraphicFrameDrawingProperties3);
            anchor3.Append(graphic3);
            anchor3.Append(relativeWidth3);
            anchor3.Append(relativeHeight3);

            drawing3.Append(anchor3);

            run102.Append(runProperties102);
            run102.Append(drawing3);
            //Text

            Run runClearences = new Run() { RsidRunAddition = "002F4CE5" };
            runClearences.Append(new Break());
            RunProperties runClearencesProps = new RunProperties();
            RunFonts runClearencesFonts = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            FontSize runClearencesFontsSize = new FontSize() { Val = "20" };
            FontSizeComplexScript CleerancefontSizeComplexScript2 = new FontSizeComplexScript() { Val = "20" };

            runClearencesProps.Append(runClearencesFonts);
            runClearencesProps.Append(runClearencesFontsSize);
            runClearencesProps.Append(CleerancefontSizeComplexScript2);
            Text text1 = new Text();
            foreach (var Certs in _Konsultant.OwnedCertificate)
            {
                text1.Text += $"{Certs.Certificate.Name} ";
            }

            runClearences.Append(runClearencesProps);
            runClearences.Append(text1);

            ClearencesPara.Append(run102);
            ClearencesParaText.Append(runClearences);
            Paragraph BreakPage = new Paragraph(new Run(new Break() { Type = BreakValues.Page }));
            #region Draw Summary Exp Pro
            Paragraph prDrawSummaryExpPro = new Paragraph() { RsidParagraphAddition = "003A795A", RsidParagraphProperties = "00C1170B", RsidRunAdditionDefault = "00985748" };
            ParagraphProperties paragraphProperties41 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties40 = new ParagraphMarkRunProperties();
            RunFonts runFonts108 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            FontSize fontSize111 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript105 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties40.Append(runFonts108);
            paragraphMarkRunProperties40.Append(fontSize111);
            paragraphMarkRunProperties40.Append(fontSizeComplexScript105);

            paragraphProperties41.Append(paragraphMarkRunProperties40);

            Run run105 = new Run();

            RunProperties runProperties105 = new RunProperties();
            NoProof noProof4 = new NoProof();

            runProperties105.Append(noProof4);



            Drawing DrawSummaryExpPro = new Drawing();

            Wp.Anchor anchor4 = new Wp.Anchor() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)114300U, DistanceFromRight = (UInt32Value)114300U, SimplePos = false, RelativeHeight = (UInt32Value)251661312U, BehindDoc = true, Locked = false, LayoutInCell = true, AllowOverlap = true };
            Wp.SimplePosition simplePosition4 = new Wp.SimplePosition() { X = 0L, Y = 0L };

            Wp.HorizontalPosition horizontalPosition4 = new Wp.HorizontalPosition() { RelativeFrom = Wp.HorizontalRelativePositionValues.Column };
            Wp.PositionOffset positionOffset7 = new Wp.PositionOffset();
            positionOffset7.Text = "-691515";

            horizontalPosition4.Append(positionOffset7);

            Wp.VerticalPosition verticalPosition4 = new Wp.VerticalPosition() { RelativeFrom = Wp.VerticalRelativePositionValues.Paragraph };
            Wp.PositionOffset positionOffset8 = new Wp.PositionOffset();
            positionOffset8.Text = "146050";

            verticalPosition4.Append(positionOffset8);
            Wp.Extent extent4 = new Wp.Extent() { Cx = 7160400L, Cy = 431739L };
            Wp.EffectExtent effectExtent4 = new Wp.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 635L };
            Wp.WrapNone wrapNone3 = new Wp.WrapNone();
            Wp.DocProperties docProperties4 = new Wp.DocProperties() { Id = (UInt32Value)8U, Name = "Image 8" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties4 = new Wp.NonVisualGraphicFrameDrawingProperties();

            A.GraphicFrameLocks graphicFrameLocks4 = new A.GraphicFrameLocks() { NoChangeAspect = true };
            graphicFrameLocks4.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            nonVisualGraphicFrameDrawingProperties4.Append(graphicFrameLocks4);

            A.Graphic graphic4 = new A.Graphic();
            graphic4.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData4 = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture4 = new Pic.Picture();
            picture4.AddNamespaceDeclaration("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture");

            Pic.NonVisualPictureProperties nonVisualPictureProperties4 = new Pic.NonVisualPictureProperties();
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties4 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)8U, Name = "SUMMARY OF PROFESSIONAL EXPERIENCES.png" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties4 = new Pic.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties4.Append(nonVisualDrawingProperties4);
            nonVisualPictureProperties4.Append(nonVisualPictureDrawingProperties4);

            Pic.BlipFill blipFill4 = new Pic.BlipFill();

            A.Blip blip4 = new A.Blip() { Embed = "rId11", CompressionState = A.BlipCompressionValues.Print };

            A.BlipExtensionList blipExtensionList4 = new A.BlipExtensionList();

            A.BlipExtension blipExtension4 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi4 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi4.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension4.Append(useLocalDpi4);

            blipExtensionList4.Append(blipExtension4);

            blip4.Append(blipExtensionList4);

            A.Stretch stretch4 = new A.Stretch();
            A.FillRectangle fillRectangle4 = new A.FillRectangle();

            stretch4.Append(fillRectangle4);

            blipFill4.Append(blip4);
            blipFill4.Append(stretch4);

            Pic.ShapeProperties shapeProperties4 = new Pic.ShapeProperties();

            A.Transform2D transform2D4 = new A.Transform2D();
            A.Offset offset4 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents4 = new A.Extents() { Cx = 7160400L, Cy = 431739L };

            transform2D4.Append(offset4);
            transform2D4.Append(extents4);

            A.PresetGeometry presetGeometry4 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList4 = new A.AdjustValueList();

            presetGeometry4.Append(adjustValueList4);

            shapeProperties4.Append(transform2D4);
            shapeProperties4.Append(presetGeometry4);

            picture4.Append(nonVisualPictureProperties4);
            picture4.Append(blipFill4);
            picture4.Append(shapeProperties4);

            graphicData4.Append(picture4);

            graphic4.Append(graphicData4);

            Wp14.RelativeWidth relativeWidth4 = new Wp14.RelativeWidth() { ObjectId = Wp14.SizeRelativeHorizontallyValues.Page };
            Wp14.PercentageWidth percentageWidth4 = new Wp14.PercentageWidth();
            percentageWidth4.Text = "0";

            relativeWidth4.Append(percentageWidth4);

            Wp14.RelativeHeight relativeHeight4 = new Wp14.RelativeHeight() { RelativeFrom = Wp14.SizeRelativeVerticallyValues.Page };
            Wp14.PercentageHeight percentageHeight4 = new Wp14.PercentageHeight();
            percentageHeight4.Text = "0";

            relativeHeight4.Append(percentageHeight4);

            anchor4.Append(simplePosition4);
            anchor4.Append(horizontalPosition4);
            anchor4.Append(verticalPosition4);
            anchor4.Append(extent4);
            anchor4.Append(effectExtent4);
            anchor4.Append(wrapNone3);
            anchor4.Append(docProperties4);
            anchor4.Append(nonVisualGraphicFrameDrawingProperties4);
            anchor4.Append(graphic4);
            anchor4.Append(relativeWidth4);
            anchor4.Append(relativeHeight4);

            DrawSummaryExpPro.Append(anchor4);

            run105.Append(runProperties105);
            run105.Append(DrawSummaryExpPro);

            prDrawSummaryExpPro.Append(paragraphProperties41);
            prDrawSummaryExpPro.Append(run105);
            #endregion
            #region Summary Exp Pro Explained
            Paragraph PrSumExpProExplained = new Paragraph() { RsidParagraphAddition = "00C1170B", RsidParagraphProperties = "00C1170B", RsidRunAdditionDefault = "00C1170B" };

            ParagraphProperties paragraphProperties42 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId17 = new ParagraphStyleId() { Val = "Sansinterligne" };

            ParagraphMarkRunProperties paragraphMarkRunProperties41 = new ParagraphMarkRunProperties();
            RunFonts runFonts109 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            FontSize fontSize112 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript106 = new FontSizeComplexScript() { Val = "20" };

            paragraphMarkRunProperties41.Append(runFonts109);
            paragraphMarkRunProperties41.Append(fontSize112);
            paragraphMarkRunProperties41.Append(fontSizeComplexScript106);

            paragraphProperties42.Append(paragraphStyleId17);
            paragraphProperties42.Append(paragraphMarkRunProperties41);

            PrSumExpProExplained.Append(paragraphProperties42);

            Paragraph paragraph46 = new Paragraph() { RsidParagraphMarkRevision = "00C1170B", RsidParagraphAddition = "00C1170B", RsidParagraphProperties = "00C1170B", RsidRunAdditionDefault = "00C1170B" };

            ParagraphProperties paragraphProperties43 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId18 = new ParagraphStyleId() { Val = "Sansinterligne" };

            paragraphProperties43.Append(paragraphStyleId18);

            paragraph46.Append(paragraphProperties43);

            Paragraph paragraph47 = new Paragraph() { RsidParagraphMarkRevision = "00C3505F", RsidParagraphAddition = "007A378A", RsidParagraphProperties = "00C1170B", RsidRunAdditionDefault = "00AF6425" };

            ParagraphProperties paragraphProperties44 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId19 = new ParagraphStyleId() { Val = "Sansinterligne" };

            ParagraphMarkRunProperties paragraphMarkRunProperties42 = new ParagraphMarkRunProperties();
            Italic italic32 = new Italic();

            paragraphMarkRunProperties42.Append(italic32);

            paragraphProperties44.Append(paragraphStyleId19);
            paragraphProperties44.Append(paragraphMarkRunProperties42);

            Run run106 = new Run();
            Text text66 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text66.Text = " ";

            run106.Append(text66);

            Run run107 = new Run() { RsidRunProperties = "00C3505F", RsidRunAddition = "007A378A" };

            RunProperties runProperties106 = new RunProperties();
            Italic italic33 = new Italic();

            runProperties106.Append(italic33);
            Text text67 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text67.Text = "You can ";

            run107.Append(runProperties106);
            run107.Append(text67);

            Run run108 = new Run() { RsidRunProperties = "00C3505F", RsidRunAddition = "00F67E7F" };

            RunProperties runProperties107 = new RunProperties();
            Italic italic34 = new Italic();

            runProperties107.Append(italic34);
            Text text68 = new Text();
            text68.Text = "list the";

            run108.Append(runProperties107);
            run108.Append(text68);

            Run run109 = new Run() { RsidRunProperties = "00C3505F", RsidRunAddition = "00C3505F" };

            RunProperties runProperties108 = new RunProperties();
            Italic italic35 = new Italic();

            runProperties108.Append(italic35);
            Text text69 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text69.Text = " main professional experiences.";

            run109.Append(runProperties108);
            run109.Append(text69);

            paragraph47.Append(paragraphProperties44);
            paragraph47.Append(run106);
            paragraph47.Append(run107);
            paragraph47.Append(run108);
            paragraph47.Append(run109);
            #endregion

            Paragraph paragraph48 = new Paragraph() { RsidParagraphMarkRevision = "007A386B", RsidParagraphAddition = "007A386B", RsidParagraphProperties = "00C1170B", RsidRunAdditionDefault = "007A386B" };

            ParagraphProperties paragraphProperties45 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId20 = new ParagraphStyleId() { Val = "Sansinterligne" };

            ParagraphMarkRunProperties paragraphMarkRunProperties43 = new ParagraphMarkRunProperties();
            FontSize fontSize113 = new FontSize() { Val = "4" };
            FontSizeComplexScript fontSizeComplexScript107 = new FontSizeComplexScript() { Val = "4" };

            paragraphMarkRunProperties43.Append(fontSize113);
            paragraphMarkRunProperties43.Append(fontSizeComplexScript107);

            paragraphProperties45.Append(paragraphStyleId20);
            paragraphProperties45.Append(paragraphMarkRunProperties43);

            paragraph48.Append(paragraphProperties45);


            Paragraph paragraph50 = new Paragraph() { RsidParagraphMarkRevision = "003A795A", RsidParagraphAddition = "003A795A", RsidParagraphProperties = "00C1170B", RsidRunAdditionDefault = "003A795A" };

            ParagraphProperties paragraphProperties47 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId22 = new ParagraphStyleId() { Val = "Sansinterligne" };

            ParagraphMarkRunProperties paragraphMarkRunProperties45 = new ParagraphMarkRunProperties();
            FontSize fontSize115 = new FontSize() { Val = "10" };
            FontSizeComplexScript fontSizeComplexScript109 = new FontSizeComplexScript() { Val = "10" };

            paragraphMarkRunProperties45.Append(fontSize115);
            paragraphMarkRunProperties45.Append(fontSizeComplexScript109);

            paragraphProperties47.Append(paragraphStyleId22);
            paragraphProperties47.Append(paragraphMarkRunProperties45);

            paragraph50.Append(paragraphProperties47);
            #region Table Exp Pro Def
            Table table4 = new Table();

            TableProperties tableProperties4 = new TableProperties();
            TableStyle tableStyle2 = new TableStyle() { Val = "Grilledutableau" };
            TablePositionProperties tablePositionProperties1 = new TablePositionProperties() { LeftFromText = 141, RightFromText = 141, VerticalAnchor = VerticalAnchorValues.Text, HorizontalAnchor = HorizontalAnchorValues.Page, TablePositionX = 832, TablePositionY = -80 };
            TableWidth tableWidth4 = new TableWidth() { Width = "10773", Type = TableWidthUnitValues.Dxa };

            TableBorders tableBorders3 = new TableBorders();
            TopBorder topBorder19 = new TopBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder18 = new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder19 = new BottomBorder() { Val = BorderValues.Single, Color = "D0CECE", ThemeColor = ThemeColorValues.Background2, ThemeShade = "E6", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder6 = new RightBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder3 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "D0CECE", ThemeColor = ThemeColorValues.Background2, ThemeShade = "E6", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder3 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "D0CECE", ThemeColor = ThemeColorValues.Background2, ThemeShade = "E6", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders3.Append(topBorder19);
            tableBorders3.Append(leftBorder18);
            tableBorders3.Append(bottomBorder19);
            tableBorders3.Append(rightBorder6);
            tableBorders3.Append(insideHorizontalBorder3);
            tableBorders3.Append(insideVerticalBorder3);
            TableLook tableLook4 = new TableLook() { Val = "04A0" };

            tableProperties4.Append(tableStyle2);
            tableProperties4.Append(tablePositionProperties1);
            tableProperties4.Append(tableWidth4);
            tableProperties4.Append(tableBorders3);
            tableProperties4.Append(tableLook4);

            TableGrid tableGrid4 = new TableGrid();
            GridColumn gridColumn9 = new GridColumn() { Width = "3544" };
            GridColumn gridColumn10 = new GridColumn() { Width = "3119" };
            GridColumn gridColumn11 = new GridColumn() { Width = "4110" };

            tableGrid4.Append(gridColumn9);
            tableGrid4.Append(gridColumn10);
            tableGrid4.Append(gridColumn11);
            #endregion
            #region Table Header
            TableRow tableRow9 = new TableRow() { RsidTableRowMarkRevision = "007A378A", RsidTableRowAddition = "00621011", RsidTableRowProperties = "00621011" };

            TableRowProperties tableRowProperties9 = new TableRowProperties();
            TableRowHeight tableRowHeight9 = new TableRowHeight() { Val = (UInt32Value)375U };

            tableRowProperties9.Append(tableRowHeight9);

            TableCell tableCell25 = new TableCell();

            TableCellProperties tableCellProperties25 = new TableCellProperties();
            TableCellWidth tableCellWidth25 = new TableCellWidth() { Width = "3544", Type = TableWidthUnitValues.Dxa };
            Shading shading24 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "304D6F" };
            TableCellVerticalAlignment tableCellVerticalAlignment23 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties25.Append(tableCellWidth25);
            tableCellProperties25.Append(shading24);
            tableCellProperties25.Append(tableCellVerticalAlignment23);

            Paragraph paragraph51 = new Paragraph() { RsidParagraphMarkRevision = "00621011", RsidParagraphAddition = "00621011", RsidParagraphProperties = "00430233", RsidRunAdditionDefault = "00621011" };

            ParagraphProperties paragraphProperties48 = new ParagraphProperties();

            Tabs tabs6 = new Tabs();
            TabStop tabStop6 = new TabStop() { Val = TabStopValues.Left, Position = 1701 };

            tabs6.Append(tabStop6);
            SpacingBetweenLines spacingBetweenLines8 = new SpacingBetweenLines() { Line = "360", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation5 = new Indentation() { End = "29" };
            Justification justification1 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties46 = new ParagraphMarkRunProperties();
            RunFonts runFonts110 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            Bold bold18 = new Bold();
            Italic italic36 = new Italic();
            Color color63 = new Color() { Val = "FFFFFF", ThemeColor = ThemeColorValues.Background1 };
            FontSize fontSize116 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript110 = new FontSizeComplexScript() { Val = "20" };
            Languages languages84 = new Languages() { Val = "en-GB" };

            paragraphMarkRunProperties46.Append(runFonts110);
            paragraphMarkRunProperties46.Append(bold18);
            paragraphMarkRunProperties46.Append(italic36);
            paragraphMarkRunProperties46.Append(color63);
            paragraphMarkRunProperties46.Append(fontSize116);
            paragraphMarkRunProperties46.Append(fontSizeComplexScript110);
            paragraphMarkRunProperties46.Append(languages84);

            paragraphProperties48.Append(tabs6);
            paragraphProperties48.Append(spacingBetweenLines8);
            paragraphProperties48.Append(indentation5);
            paragraphProperties48.Append(justification1);
            paragraphProperties48.Append(paragraphMarkRunProperties46);

            Run run110 = new Run();

            RunProperties runProperties109 = new RunProperties();
            RunFonts runFonts111 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            Bold bold19 = new Bold();
            Color color64 = new Color() { Val = "FFFFFF", ThemeColor = ThemeColorValues.Background1 };
            FontSize fontSize117 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript111 = new FontSizeComplexScript() { Val = "20" };
            Languages languages85 = new Languages() { Val = "en-GB" };

            runProperties109.Append(runFonts111);
            runProperties109.Append(bold19);
            runProperties109.Append(color64);
            runProperties109.Append(fontSize117);
            runProperties109.Append(fontSizeComplexScript111);
            runProperties109.Append(languages85);
            Text text70 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text70.Text = "From ";

            run110.Append(runProperties109);
            run110.Append(text70);

            Run run111 = new Run();

            RunProperties runProperties110 = new RunProperties();
            RunFonts runFonts112 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            Bold bold20 = new Bold();
            Italic italic37 = new Italic();
            Color color65 = new Color() { Val = "FFFFFF", ThemeColor = ThemeColorValues.Background1 };
            FontSize fontSize118 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript112 = new FontSizeComplexScript() { Val = "20" };
            Languages languages86 = new Languages() { Val = "en-GB" };

            runProperties110.Append(runFonts112);
            runProperties110.Append(bold20);
            runProperties110.Append(italic37);
            runProperties110.Append(color65);
            runProperties110.Append(fontSize118);
            runProperties110.Append(fontSizeComplexScript112);
            runProperties110.Append(languages86);
            Text text71 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text71.Text = "month/year ";

            run111.Append(runProperties110);
            run111.Append(text71);

            Run run112 = new Run() { RsidRunProperties = "00621011" };

            RunProperties runProperties111 = new RunProperties();
            RunFonts runFonts113 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            Bold bold21 = new Bold();
            Color color66 = new Color() { Val = "FFFFFF", ThemeColor = ThemeColorValues.Background1 };
            FontSize fontSize119 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript113 = new FontSizeComplexScript() { Val = "20" };
            Languages languages87 = new Languages() { Val = "en-GB" };

            runProperties111.Append(runFonts113);
            runProperties111.Append(bold21);
            runProperties111.Append(color66);
            runProperties111.Append(fontSize119);
            runProperties111.Append(fontSizeComplexScript113);
            runProperties111.Append(languages87);
            Text text72 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text72.Text = "till ";

            run112.Append(runProperties111);
            run112.Append(text72);

            Run run113 = new Run();

            RunProperties runProperties112 = new RunProperties();
            RunFonts runFonts114 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            Bold bold22 = new Bold();
            Italic italic38 = new Italic();
            Color color67 = new Color() { Val = "FFFFFF", ThemeColor = ThemeColorValues.Background1 };
            FontSize fontSize120 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript114 = new FontSizeComplexScript() { Val = "20" };
            Languages languages88 = new Languages() { Val = "en-GB" };

            runProperties112.Append(runFonts114);
            runProperties112.Append(bold22);
            runProperties112.Append(italic38);
            runProperties112.Append(color67);
            runProperties112.Append(fontSize120);
            runProperties112.Append(fontSizeComplexScript114);
            runProperties112.Append(languages88);
            Text text73 = new Text();
            text73.Text = "month/year";

            run113.Append(runProperties112);
            run113.Append(text73);

            paragraph51.Append(paragraphProperties48);
            paragraph51.Append(run110);
            paragraph51.Append(run111);
            paragraph51.Append(run112);
            paragraph51.Append(run113);

            tableCell25.Append(tableCellProperties25);
            tableCell25.Append(paragraph51);

            TableCell tableCell26 = new TableCell();

            TableCellProperties tableCellProperties26 = new TableCellProperties();
            TableCellWidth tableCellWidth26 = new TableCellWidth() { Width = "3119", Type = TableWidthUnitValues.Dxa };
            Shading shading25 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "304D6F" };
            TableCellVerticalAlignment tableCellVerticalAlignment24 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties26.Append(tableCellWidth26);
            tableCellProperties26.Append(shading25);
            tableCellProperties26.Append(tableCellVerticalAlignment24);

            Paragraph paragraph52 = new Paragraph() { RsidParagraphMarkRevision = "007A378A", RsidParagraphAddition = "00621011", RsidParagraphProperties = "00430233", RsidRunAdditionDefault = "00621011" };

            ParagraphProperties paragraphProperties49 = new ParagraphProperties();

            Tabs tabs7 = new Tabs();
            TabStop tabStop7 = new TabStop() { Val = TabStopValues.Left, Position = 1701 };

            tabs7.Append(tabStop7);
            SpacingBetweenLines spacingBetweenLines9 = new SpacingBetweenLines() { Line = "360", LineRule = LineSpacingRuleValues.Auto };
            Justification justification2 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties47 = new ParagraphMarkRunProperties();
            RunFonts runFonts115 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            Bold bold23 = new Bold();
            Color color68 = new Color() { Val = "FFFFFF", ThemeColor = ThemeColorValues.Background1 };
            FontSize fontSize121 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript115 = new FontSizeComplexScript() { Val = "20" };
            Languages languages89 = new Languages() { Val = "en-GB" };

            paragraphMarkRunProperties47.Append(runFonts115);
            paragraphMarkRunProperties47.Append(bold23);
            paragraphMarkRunProperties47.Append(color68);
            paragraphMarkRunProperties47.Append(fontSize121);
            paragraphMarkRunProperties47.Append(fontSizeComplexScript115);
            paragraphMarkRunProperties47.Append(languages89);

            paragraphProperties49.Append(tabs7);
            paragraphProperties49.Append(spacingBetweenLines9);
            paragraphProperties49.Append(justification2);
            paragraphProperties49.Append(paragraphMarkRunProperties47);

            Run run114 = new Run();

            RunProperties runProperties113 = new RunProperties();
            RunFonts runFonts116 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            Bold bold24 = new Bold();
            Color color69 = new Color() { Val = "FFFFFF", ThemeColor = ThemeColorValues.Background1 };
            FontSize fontSize122 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript116 = new FontSizeComplexScript() { Val = "20" };
            Languages languages90 = new Languages() { Val = "en-GB" };

            runProperties113.Append(runFonts116);
            runProperties113.Append(bold24);
            runProperties113.Append(color69);
            runProperties113.Append(fontSize122);
            runProperties113.Append(fontSizeComplexScript116);
            runProperties113.Append(languages90);
            Text text74 = new Text();
            text74.Text = "Company";

            run114.Append(runProperties113);
            run114.Append(text74);

            paragraph52.Append(paragraphProperties49);
            paragraph52.Append(run114);

            tableCell26.Append(tableCellProperties26);
            tableCell26.Append(paragraph52);

            TableCell tableCell27 = new TableCell();

            TableCellProperties tableCellProperties27 = new TableCellProperties();
            TableCellWidth tableCellWidth27 = new TableCellWidth() { Width = "4110", Type = TableWidthUnitValues.Dxa };
            Shading shading26 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "304D6F" };
            TableCellVerticalAlignment tableCellVerticalAlignment25 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties27.Append(tableCellWidth27);
            tableCellProperties27.Append(shading26);
            tableCellProperties27.Append(tableCellVerticalAlignment25);

            Paragraph paragraph53 = new Paragraph() { RsidParagraphMarkRevision = "007A378A", RsidParagraphAddition = "00621011", RsidParagraphProperties = "00430233", RsidRunAdditionDefault = "00621011" };

            ParagraphProperties paragraphProperties50 = new ParagraphProperties();

            Tabs tabs8 = new Tabs();
            TabStop tabStop8 = new TabStop() { Val = TabStopValues.Left, Position = 1701 };

            tabs8.Append(tabStop8);
            SpacingBetweenLines spacingBetweenLines10 = new SpacingBetweenLines() { Line = "360", LineRule = LineSpacingRuleValues.Auto };
            Justification justification3 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties48 = new ParagraphMarkRunProperties();
            RunFonts runFonts117 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            Bold bold25 = new Bold();
            Color color70 = new Color() { Val = "FFFFFF", ThemeColor = ThemeColorValues.Background1 };
            FontSize fontSize123 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript117 = new FontSizeComplexScript() { Val = "20" };
            Languages languages91 = new Languages() { Val = "en-GB" };

            paragraphMarkRunProperties48.Append(runFonts117);
            paragraphMarkRunProperties48.Append(bold25);
            paragraphMarkRunProperties48.Append(color70);
            paragraphMarkRunProperties48.Append(fontSize123);
            paragraphMarkRunProperties48.Append(fontSizeComplexScript117);
            paragraphMarkRunProperties48.Append(languages91);

            paragraphProperties50.Append(tabs8);
            paragraphProperties50.Append(spacingBetweenLines10);
            paragraphProperties50.Append(justification3);
            paragraphProperties50.Append(paragraphMarkRunProperties48);

            Run run115 = new Run();

            RunProperties runProperties114 = new RunProperties();
            RunFonts runFonts118 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
            Bold bold26 = new Bold();
            Color color71 = new Color() { Val = "FFFFFF", ThemeColor = ThemeColorValues.Background1 };
            FontSize fontSize124 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript118 = new FontSizeComplexScript() { Val = "20" };
            Languages languages92 = new Languages() { Val = "en-GB" };

            runProperties114.Append(runFonts118);
            runProperties114.Append(bold26);
            runProperties114.Append(color71);
            runProperties114.Append(fontSize124);
            runProperties114.Append(fontSizeComplexScript118);
            runProperties114.Append(languages92);
            Text text75 = new Text();
            text75.Text = "Position";

            run115.Append(runProperties114);
            run115.Append(text75);

            paragraph53.Append(paragraphProperties50);
            paragraph53.Append(run115);

            tableCell27.Append(tableCellProperties27);
            tableCell27.Append(paragraph53);

            tableRow9.Append(tableRowProperties9);
            tableRow9.Append(tableCell25);
            tableRow9.Append(tableCell26);
            tableRow9.Append(tableCell27);
            #endregion
            table4.Append(tableProperties4);
            table4.Append(tableGrid4);
            table4.Append(tableRow9);
            #region Table Summary Experiences 

            foreach (var Exp in _Konsultant.ProfessionalExperience)
            {


                TableRow tableRow10 = new TableRow() { RsidTableRowMarkRevision = "007A378A", RsidTableRowAddition = "00621011", RsidTableRowProperties = "00621011" };

                TableRowProperties tableRowProperties10 = new TableRowProperties();
                TableRowHeight tableRowHeight10 = new TableRowHeight() { Val = (UInt32Value)375U };

                tableRowProperties10.Append(tableRowHeight10);

                TableCell tableCell28 = new TableCell();

                TableCellProperties tableCellProperties28 = new TableCellProperties();
                TableCellWidth tableCellWidth28 = new TableCellWidth() { Width = "3544", Type = TableWidthUnitValues.Dxa };
                TableCellVerticalAlignment tableCellVerticalAlignment26 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

                tableCellProperties28.Append(tableCellWidth28);
                tableCellProperties28.Append(tableCellVerticalAlignment26);

                Paragraph paragraph54 = new Paragraph() { RsidParagraphMarkRevision = "007A378A", RsidParagraphAddition = "00621011", RsidParagraphProperties = "00430233", RsidRunAdditionDefault = "00621011" };

                ParagraphProperties paragraphProperties51 = new ParagraphProperties();

                Tabs tabs9 = new Tabs();
                TabStop tabStop9 = new TabStop() { Val = TabStopValues.Left, Position = 1701 };

                tabs9.Append(tabStop9);
                SpacingBetweenLines spacingBetweenLines11 = new SpacingBetweenLines() { Line = "360", LineRule = LineSpacingRuleValues.Auto };
                Justification justification4 = new Justification() { Val = JustificationValues.Center };

                ParagraphMarkRunProperties paragraphMarkRunProperties49 = new ParagraphMarkRunProperties();
                RunFonts runFonts119 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize125 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript119 = new FontSizeComplexScript() { Val = "20" };
                Languages languages93 = new Languages() { Val = "en-GB" };

                paragraphMarkRunProperties49.Append(runFonts119);
                paragraphMarkRunProperties49.Append(fontSize125);
                paragraphMarkRunProperties49.Append(fontSizeComplexScript119);
                paragraphMarkRunProperties49.Append(languages93);

                paragraphProperties51.Append(tabs9);
                paragraphProperties51.Append(spacingBetweenLines11);
                paragraphProperties51.Append(justification4);
                paragraphProperties51.Append(paragraphMarkRunProperties49);

                Run run116 = new Run();

                RunProperties runProperties115 = new RunProperties();
                RunFonts runFonts120 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize126 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript120 = new FontSizeComplexScript() { Val = "20" };
                Languages languages94 = new Languages() { Val = "en-GB" };

                runProperties115.Append(runFonts120);
                runProperties115.Append(fontSize126);
                runProperties115.Append(fontSizeComplexScript120);
                runProperties115.Append(languages94);
                Text text76 = new Text();
                text76.Text = $"{Exp.StartDate.ToShortDateString() }till";

                run116.Append(runProperties115);
                run116.Append(text76);

                Run run117 = new Run() { RsidRunProperties = "007A378A" };

                RunProperties runProperties116 = new RunProperties();
                RunFonts runFonts121 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize127 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript121 = new FontSizeComplexScript() { Val = "20" };
                Languages languages95 = new Languages() { Val = "en-GB" };

                runProperties116.Append(runFonts121);
                runProperties116.Append(fontSize127);
                runProperties116.Append(fontSizeComplexScript121);
                runProperties116.Append(languages95);
                Text text77 = new Text() { Space = SpaceProcessingModeValues.Preserve };
                text77.Text = " ";

                run117.Append(runProperties116);
                run117.Append(text77);

                Run run118 = new Run();

                RunProperties runProperties117 = new RunProperties();
                RunFonts runFonts122 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize128 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript122 = new FontSizeComplexScript() { Val = "20" };
                Languages languages96 = new Languages() { Val = "en-GB" };

                runProperties117.Append(runFonts122);
                runProperties117.Append(fontSize128);
                runProperties117.Append(fontSizeComplexScript122);
                runProperties117.Append(languages96);
                Text text78 = new Text();
                text78.Text = $"{Exp.EndDate.ToShortDateString()}";

                run118.Append(runProperties117);
                run118.Append(text78);

                //Run run119 = new Run() { RsidRunProperties = "007A378A" };

                //RunProperties runProperties118 = new RunProperties();
                //RunFonts runFonts123 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                //FontSize fontSize129 = new FontSize() { Val = "20" };
                //FontSizeComplexScript fontSizeComplexScript123 = new FontSizeComplexScript() { Val = "20" };
                //Languages languages97 = new Languages() { Val = "en-GB" };

                //runProperties118.Append(runFonts123);
                //runProperties118.Append(fontSize129);
                //runProperties118.Append(fontSizeComplexScript123);
                //runProperties118.Append(languages97);
                //Text text79 = new Text();
                //text79.Text = "2018";

                //run119.Append(runProperties118);
                //run119.Append(text79);

                paragraph54.Append(paragraphProperties51);
                paragraph54.Append(run116);
                paragraph54.Append(run117);
                paragraph54.Append(run118);
                //paragraph54.Append(run119);

                tableCell28.Append(tableCellProperties28);
                tableCell28.Append(paragraph54);

                TableCell tableCell29 = new TableCell();

                TableCellProperties tableCellProperties29 = new TableCellProperties();
                TableCellWidth tableCellWidth29 = new TableCellWidth() { Width = "3119", Type = TableWidthUnitValues.Dxa };
                TableCellVerticalAlignment tableCellVerticalAlignment27 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

                tableCellProperties29.Append(tableCellWidth29);
                tableCellProperties29.Append(tableCellVerticalAlignment27);

                Paragraph paragraph55 = new Paragraph() { RsidParagraphMarkRevision = "007A378A", RsidParagraphAddition = "00621011", RsidParagraphProperties = "00430233", RsidRunAdditionDefault = "00621011" };

                ParagraphProperties paragraphProperties52 = new ParagraphProperties();

                Tabs tabs10 = new Tabs();
                TabStop tabStop10 = new TabStop() { Val = TabStopValues.Left, Position = 1701 };

                tabs10.Append(tabStop10);
                SpacingBetweenLines spacingBetweenLines12 = new SpacingBetweenLines() { Line = "360", LineRule = LineSpacingRuleValues.Auto };
                Justification justification5 = new Justification() { Val = JustificationValues.Center };

                ParagraphMarkRunProperties paragraphMarkRunProperties50 = new ParagraphMarkRunProperties();
                RunFonts runFonts124 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize130 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript124 = new FontSizeComplexScript() { Val = "20" };
                Languages languages98 = new Languages() { Val = "en-GB" };

                paragraphMarkRunProperties50.Append(runFonts124);
                paragraphMarkRunProperties50.Append(fontSize130);
                paragraphMarkRunProperties50.Append(fontSizeComplexScript124);
                paragraphMarkRunProperties50.Append(languages98);

                paragraphProperties52.Append(tabs10);
                paragraphProperties52.Append(spacingBetweenLines12);
                paragraphProperties52.Append(justification5);
                paragraphProperties52.Append(paragraphMarkRunProperties50);

                Run run120 = new Run() { RsidRunProperties = "007A378A" };

                RunProperties runProperties119 = new RunProperties();
                RunFonts runFonts125 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize131 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript125 = new FontSizeComplexScript() { Val = "20" };
                Languages languages99 = new Languages() { Val = "en-GB" };

                runProperties119.Append(runFonts125);
                runProperties119.Append(fontSize131);
                runProperties119.Append(fontSizeComplexScript125);
                runProperties119.Append(languages99);
                Text text80 = new Text();
                text80.Text = $"{Exp.Customer}";

                run120.Append(runProperties119);
                run120.Append(text80);

                paragraph55.Append(paragraphProperties52);
                paragraph55.Append(run120);

                tableCell29.Append(tableCellProperties29);
                tableCell29.Append(paragraph55);

                TableCell tableCell30 = new TableCell();

                TableCellProperties tableCellProperties30 = new TableCellProperties();
                TableCellWidth tableCellWidth30 = new TableCellWidth() { Width = "4110", Type = TableWidthUnitValues.Dxa };
                TableCellVerticalAlignment tableCellVerticalAlignment28 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

                tableCellProperties30.Append(tableCellWidth30);
                tableCellProperties30.Append(tableCellVerticalAlignment28);

                Paragraph paragraph56 = new Paragraph() { RsidParagraphMarkRevision = "007A378A", RsidParagraphAddition = "00621011", RsidParagraphProperties = "00430233", RsidRunAdditionDefault = "00621011" };

                ParagraphProperties paragraphProperties53 = new ParagraphProperties();

                Tabs tabs11 = new Tabs();
                TabStop tabStop11 = new TabStop() { Val = TabStopValues.Left, Position = 1701 };

                tabs11.Append(tabStop11);
                SpacingBetweenLines spacingBetweenLines13 = new SpacingBetweenLines() { Line = "360", LineRule = LineSpacingRuleValues.Auto };
                Indentation indentation6 = new Indentation() { Start = "1701", Hanging = "1701" };
                Justification justification6 = new Justification() { Val = JustificationValues.Center };

                ParagraphMarkRunProperties paragraphMarkRunProperties51 = new ParagraphMarkRunProperties();
                RunFonts runFonts126 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize132 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript126 = new FontSizeComplexScript() { Val = "20" };
                Languages languages100 = new Languages() { Val = "en-GB" };

                paragraphMarkRunProperties51.Append(runFonts126);
                paragraphMarkRunProperties51.Append(fontSize132);
                paragraphMarkRunProperties51.Append(fontSizeComplexScript126);
                paragraphMarkRunProperties51.Append(languages100);

                paragraphProperties53.Append(tabs11);
                paragraphProperties53.Append(spacingBetweenLines13);
                paragraphProperties53.Append(indentation6);
                paragraphProperties53.Append(justification6);
                paragraphProperties53.Append(paragraphMarkRunProperties51);

                Run run121 = new Run();

                RunProperties runProperties120 = new RunProperties();
                RunFonts runFonts127 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                FontSize fontSize133 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript127 = new FontSizeComplexScript() { Val = "20" };
                Languages languages101 = new Languages() { Val = "en-GB" };

                runProperties120.Append(runFonts127);
                runProperties120.Append(fontSize133);
                runProperties120.Append(fontSizeComplexScript127);
                runProperties120.Append(languages101);
                Text text81 = new Text();
                text81.Text = $"{Exp.Position}";

                run121.Append(runProperties120);
                run121.Append(text81);


                paragraph56.Append(paragraphProperties53);
                paragraph56.Append(run121);

                tableCell30.Append(tableCellProperties30);
                tableCell30.Append(paragraph56);

                tableRow10.Append(tableRowProperties10);
                tableRow10.Append(tableCell28);
                tableRow10.Append(tableCell29);
                tableRow10.Append(tableCell30);
                table4.Append(tableRow10);

            }
            #endregion

            Paragraph paragraph66 = new Paragraph() { RsidParagraphAddition = "006B4E5C", RsidParagraphProperties = "00985748", RsidRunAdditionDefault = "004C1D0B" };

            Run run123 = new Run();
            LastRenderedPageBreak lastRenderedPageBreak1 = new LastRenderedPageBreak();
            Text text83 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text83.Text = " ";

            run123.Append(lastRenderedPageBreak1);
            run123.Append(text83);

            paragraph66.Append(run123);

            Paragraph paragraph67 = new Paragraph() { RsidParagraphAddition = "00990EF5", RsidParagraphProperties = "003A795A", RsidRunAdditionDefault = "00990EF5" };

            ParagraphProperties paragraphProperties63 = new ParagraphProperties();
            Indentation indentation7 = new Indentation() { Start = "-993", FirstLine = "993" };

            paragraphProperties63.Append(indentation7);

            Run run124 = new Run();

            RunProperties runProperties122 = new RunProperties();
            NoProof noProof5 = new NoProof();

            runProperties122.Append(noProof5);

            Drawing drawing5 = new Drawing();

            Wp.Anchor anchor5 = new Wp.Anchor() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)114300U, DistanceFromRight = (UInt32Value)114300U, SimplePos = false, RelativeHeight = (UInt32Value)251662336U, BehindDoc = true, Locked = false, LayoutInCell = true, AllowOverlap = true };
            Wp.SimplePosition simplePosition5 = new Wp.SimplePosition() { X = 0L, Y = 0L };

            Wp.HorizontalPosition horizontalPosition5 = new Wp.HorizontalPosition() { RelativeFrom = Wp.HorizontalRelativePositionValues.Column };
            Wp.PositionOffset positionOffset9 = new Wp.PositionOffset();
            positionOffset9.Text = "-654685";

            horizontalPosition5.Append(positionOffset9);

            Wp.VerticalPosition verticalPosition5 = new Wp.VerticalPosition() { RelativeFrom = Wp.VerticalRelativePositionValues.Paragraph };
            Wp.PositionOffset positionOffset10 = new Wp.PositionOffset();
            positionOffset10.Text = "-27871";

            verticalPosition5.Append(positionOffset10);
            Wp.Extent extent5 = new Wp.Extent() { Cx = 7160400L, Cy = 431739L };
            Wp.EffectExtent effectExtent5 = new Wp.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 635L };
            Wp.WrapNone wrapNone4 = new Wp.WrapNone();
            Wp.DocProperties docProperties5 = new Wp.DocProperties() { Id = (UInt32Value)9U, Name = "Image 9" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties5 = new Wp.NonVisualGraphicFrameDrawingProperties();

            A.GraphicFrameLocks graphicFrameLocks5 = new A.GraphicFrameLocks() { NoChangeAspect = true };
            graphicFrameLocks5.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            nonVisualGraphicFrameDrawingProperties5.Append(graphicFrameLocks5);

            A.Graphic graphic5 = new A.Graphic();
            graphic5.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData5 = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture5 = new Pic.Picture();
            picture5.AddNamespaceDeclaration("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture");

            Pic.NonVisualPictureProperties nonVisualPictureProperties5 = new Pic.NonVisualPictureProperties();
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties5 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)9U, Name = "PROFESSIONAL EXPERIENCES.png" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties5 = new Pic.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties5.Append(nonVisualDrawingProperties5);
            nonVisualPictureProperties5.Append(nonVisualPictureDrawingProperties5);

            Pic.BlipFill blipFill5 = new Pic.BlipFill();

            A.Blip blip5 = new A.Blip() { Embed = "rId12", CompressionState = A.BlipCompressionValues.Print };

            A.BlipExtensionList blipExtensionList5 = new A.BlipExtensionList();

            A.BlipExtension blipExtension5 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi5 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi5.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension5.Append(useLocalDpi5);

            blipExtensionList5.Append(blipExtension5);

            blip5.Append(blipExtensionList5);

            A.Stretch stretch5 = new A.Stretch();
            A.FillRectangle fillRectangle5 = new A.FillRectangle();

            stretch5.Append(fillRectangle5);

            blipFill5.Append(blip5);
            blipFill5.Append(stretch5);

            Pic.ShapeProperties shapeProperties5 = new Pic.ShapeProperties();

            A.Transform2D transform2D5 = new A.Transform2D();
            A.Offset offset5 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents5 = new A.Extents() { Cx = 7160400L, Cy = 431739L };

            transform2D5.Append(offset5);
            transform2D5.Append(extents5);

            A.PresetGeometry presetGeometry5 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList5 = new A.AdjustValueList();

            presetGeometry5.Append(adjustValueList5);

            shapeProperties5.Append(transform2D5);
            shapeProperties5.Append(presetGeometry5);

            picture5.Append(nonVisualPictureProperties5);
            picture5.Append(blipFill5);
            picture5.Append(shapeProperties5);

            graphicData5.Append(picture5);

            graphic5.Append(graphicData5);

            Wp14.RelativeWidth relativeWidth5 = new Wp14.RelativeWidth() { ObjectId = Wp14.SizeRelativeHorizontallyValues.Page };
            Wp14.PercentageWidth percentageWidth5 = new Wp14.PercentageWidth();
            percentageWidth5.Text = "0";

            relativeWidth5.Append(percentageWidth5);

            Wp14.RelativeHeight relativeHeight5 = new Wp14.RelativeHeight() { RelativeFrom = Wp14.SizeRelativeVerticallyValues.Page };
            Wp14.PercentageHeight percentageHeight5 = new Wp14.PercentageHeight();
            percentageHeight5.Text = "0";

            relativeHeight5.Append(percentageHeight5);

            anchor5.Append(simplePosition5);
            anchor5.Append(horizontalPosition5);
            anchor5.Append(verticalPosition5);
            anchor5.Append(extent5);
            anchor5.Append(effectExtent5);
            anchor5.Append(wrapNone4);
            anchor5.Append(docProperties5);
            anchor5.Append(nonVisualGraphicFrameDrawingProperties5);
            anchor5.Append(graphic5);
            anchor5.Append(relativeWidth5);
            anchor5.Append(relativeHeight5);

            drawing5.Append(anchor5);

            run124.Append(runProperties122);
            run124.Append(drawing5);

            paragraph67.Append(paragraphProperties63);
            paragraph67.Append(run124);

            Paragraph paragraph68 = new Paragraph() { RsidParagraphAddition = "00AF6425", RsidParagraphProperties = "003A795A", RsidRunAdditionDefault = "00AF6425" };

            ParagraphProperties paragraphProperties64 = new ParagraphProperties();
            Indentation indentation8 = new Indentation() { Start = "-993", FirstLine = "993" };

            paragraphProperties64.Append(indentation8);

            paragraph68.Append(paragraphProperties64);


            //Start here 

            Paragraph paragraph86 = new Paragraph() { RsidParagraphMarkRevision = "006A08FF", RsidParagraphAddition = "00985748", RsidParagraphProperties = "00985748", RsidRunAdditionDefault = "00985748" };

            ParagraphProperties paragraphProperties82 = new ParagraphProperties();

            Tabs tabs38 = new Tabs();
            TabStop tabStop45 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

            tabs38.Append(tabStop45);
            Justification justification26 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties78 = new ParagraphMarkRunProperties();
            RunFonts runFonts189 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
            BoldComplexScript boldComplexScript29 = new BoldComplexScript();
            ItalicComplexScript italicComplexScript27 = new ItalicComplexScript();
            FontSize fontSize191 = new FontSize() { Val = "20" };
            FontSizeComplexScript fontSizeComplexScript189 = new FontSizeComplexScript() { Val = "20" };
            Languages languages151 = new Languages() { EastAsia = "fr-FR" };

            paragraphMarkRunProperties78.Append(runFonts189);
            paragraphMarkRunProperties78.Append(boldComplexScript29);
            paragraphMarkRunProperties78.Append(italicComplexScript27);
            paragraphMarkRunProperties78.Append(fontSize191);
            paragraphMarkRunProperties78.Append(fontSizeComplexScript189);
            paragraphMarkRunProperties78.Append(languages151);

            paragraphProperties82.Append(tabs38);
            paragraphProperties82.Append(justification26);
            paragraphProperties82.Append(paragraphMarkRunProperties78);

            Run run159 = new Run();

            RunProperties runProperties157 = new RunProperties();
            NoProof noProof6 = new NoProof();

            runProperties157.Append(noProof6);

            //MaybeEnd
            Drawing drawing6 = new Drawing();

            Wp.Anchor anchor6 = new Wp.Anchor() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)114300U, DistanceFromRight = (UInt32Value)114300U, SimplePos = false, RelativeHeight = (UInt32Value)251663360U, BehindDoc = true, Locked = false, LayoutInCell = true, AllowOverlap = true };
            Wp.SimplePosition simplePosition6 = new Wp.SimplePosition() { X = 0L, Y = 0L };

            Wp.HorizontalPosition horizontalPosition6 = new Wp.HorizontalPosition() { RelativeFrom = Wp.HorizontalRelativePositionValues.Column };
            Wp.PositionOffset positionOffset11 = new Wp.PositionOffset();
            positionOffset11.Text = "-685800";

            horizontalPosition6.Append(positionOffset11);

            Wp.VerticalPosition verticalPosition6 = new Wp.VerticalPosition() { RelativeFrom = Wp.VerticalRelativePositionValues.Paragraph };
            Wp.PositionOffset positionOffset12 = new Wp.PositionOffset();
            positionOffset12.Text = "146568";

            verticalPosition6.Append(positionOffset12);
            Wp.Extent extent6 = new Wp.Extent() { Cx = 7160260L, Cy = 431165L };
            Wp.EffectExtent effectExtent6 = new Wp.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 635L };
            Wp.WrapNone wrapNone5 = new Wp.WrapNone();
            Wp.DocProperties docProperties6 = new Wp.DocProperties() { Id = (UInt32Value)11U, Name = "Image 11" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties6 = new Wp.NonVisualGraphicFrameDrawingProperties();

            A.GraphicFrameLocks graphicFrameLocks6 = new A.GraphicFrameLocks() { NoChangeAspect = true };
            graphicFrameLocks6.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            nonVisualGraphicFrameDrawingProperties6.Append(graphicFrameLocks6);

            A.Graphic graphic6 = new A.Graphic();
            graphic6.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData6 = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture6 = new Pic.Picture();
            picture6.AddNamespaceDeclaration("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture");

            Pic.NonVisualPictureProperties nonVisualPictureProperties6 = new Pic.NonVisualPictureProperties();
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties6 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)11U, Name = "PROFESSIONAL REFERENCES.png" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties6 = new Pic.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties6.Append(nonVisualDrawingProperties6);
            nonVisualPictureProperties6.Append(nonVisualPictureDrawingProperties6);

            Pic.BlipFill blipFill6 = new Pic.BlipFill();

            A.Blip blip6 = new A.Blip() { Embed = "rId13", CompressionState = A.BlipCompressionValues.Print };

            A.BlipExtensionList blipExtensionList6 = new A.BlipExtensionList();

            A.BlipExtension blipExtension6 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi6 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi6.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension6.Append(useLocalDpi6);

            blipExtensionList6.Append(blipExtension6);

            blip6.Append(blipExtensionList6);

            A.Stretch stretch6 = new A.Stretch();
            A.FillRectangle fillRectangle6 = new A.FillRectangle();

            stretch6.Append(fillRectangle6);

            blipFill6.Append(blip6);
            blipFill6.Append(stretch6);

            Pic.ShapeProperties shapeProperties6 = new Pic.ShapeProperties();

            A.Transform2D transform2D6 = new A.Transform2D();
            A.Offset offset6 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents6 = new A.Extents() { Cx = 7160260L, Cy = 431165L };

            transform2D6.Append(offset6);
            transform2D6.Append(extents6);

            A.PresetGeometry presetGeometry6 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList6 = new A.AdjustValueList();

            presetGeometry6.Append(adjustValueList6);

            shapeProperties6.Append(transform2D6);
            shapeProperties6.Append(presetGeometry6);

            picture6.Append(nonVisualPictureProperties6);
            picture6.Append(blipFill6);
            picture6.Append(shapeProperties6);

            graphicData6.Append(picture6);

            graphic6.Append(graphicData6);

            Wp14.RelativeWidth relativeWidth6 = new Wp14.RelativeWidth() { ObjectId = Wp14.SizeRelativeHorizontallyValues.Page };
            Wp14.PercentageWidth percentageWidth6 = new Wp14.PercentageWidth();
            percentageWidth6.Text = "0";

            relativeWidth6.Append(percentageWidth6);

            Wp14.RelativeHeight relativeHeight6 = new Wp14.RelativeHeight() { RelativeFrom = Wp14.SizeRelativeVerticallyValues.Page };
            Wp14.PercentageHeight percentageHeight6 = new Wp14.PercentageHeight();
            percentageHeight6.Text = "0";

            relativeHeight6.Append(percentageHeight6);

            anchor6.Append(simplePosition6);
            anchor6.Append(horizontalPosition6);
            anchor6.Append(verticalPosition6);
            anchor6.Append(extent6);
            anchor6.Append(effectExtent6);
            anchor6.Append(wrapNone5);
            anchor6.Append(docProperties6);
            anchor6.Append(nonVisualGraphicFrameDrawingProperties6);
            anchor6.Append(graphic6);
            anchor6.Append(relativeWidth6);
            anchor6.Append(relativeHeight6);

            drawing6.Append(anchor6);

            run159.Append(runProperties157);
            run159.Append(drawing6);

            paragraph86.Append(paragraphProperties82);
            paragraph86.Append(run159);
            Paragraph paragraph87 = new Paragraph() { RsidParagraphAddition = "00AF6425", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "00AF6425" };


            Paragraph paragraph88 = new Paragraph() { RsidParagraphAddition = "006051D6", RsidParagraphProperties = "00AF6425", RsidRunAdditionDefault = "006051D6" };
            ParagraphProperties paragraphProperties83 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId26 = new ParagraphStyleId() { Val = "Paragraphedeliste" };

            NumberingProperties numberingProperties4 = new NumberingProperties();
            NumberingLevelReference numberingLevelReference4 = new NumberingLevelReference() { Val = 0 };
            NumberingId numberingId4 = new NumberingId() { Val = 2 };

            numberingProperties4.Append(numberingLevelReference4);
            numberingProperties4.Append(numberingId4);

            paragraphProperties83.Append(paragraphStyleId26);
            paragraphProperties83.Append(numberingProperties4);
            paragraph88.Append(paragraphProperties83);

            foreach (var Refs in _Konsultant.ProfessionalReference)
            {
                Run run160 = new Run();
                Text text118 = new Text();
                text118.Text = $"{Refs.Name} {Refs.Surname} {Refs.Company} {Refs.Function} {Refs.Contact.Phone} {Refs.Contact.Mail}";

                run160.Append(text118);

                paragraph88.Append(run160);
            }




            Paragraph paragraph90 = new Paragraph() { RsidParagraphMarkRevision = "006051D6", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "004C1D0B", RsidRunAdditionDefault = "006051D6" };

            SectionProperties sectionProperties1 = new SectionProperties() { RsidRPr = "006051D6", RsidR = "006051D6", RsidSect = "006B4E5C" };
            HeaderReference headerReference1 = new HeaderReference() { Type = HeaderFooterValues.Default, Id = "rId14" };
            FooterReference footerReference1 = new FooterReference() { Type = HeaderFooterValues.Even, Id = "rId15" };
            FooterReference footerReference2 = new FooterReference() { Type = HeaderFooterValues.Default, Id = "rId16" };
            HeaderReference headerReference2 = new HeaderReference() { Type = HeaderFooterValues.First, Id = "rId17" };
            FooterReference footerReference3 = new FooterReference() { Type = HeaderFooterValues.First, Id = "rId18" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin() { Top = 1788, Right = (UInt32Value)1417U, Bottom = 1417, Left = (UInt32Value)1417U, Header = (UInt32Value)708U, Footer = (UInt32Value)708U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "708" };
            TitlePage titlePage1 = new TitlePage();
            DocGrid docGrid1 = new DocGrid() { LinePitch = 360 };

            sectionProperties1.Append(headerReference1);
            sectionProperties1.Append(footerReference1);
            sectionProperties1.Append(footerReference2);
            sectionProperties1.Append(headerReference2);
            sectionProperties1.Append(footerReference3);
            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(titlePage1);
            sectionProperties1.Append(docGrid1);

            body1.Append(paragraph1);
            body1.Append(paragraph2);
            body1.Append(paragraph3);
            body1.Append(paragraph5);
            body1.Append(tableCompetence);
            body1.Append(paragraph22);
            body1.Append(table2);
            //body1.Append(paragraph36);
            if (_Konsultant.PersonalEducation.Any())
                body1.Append(EducationTitle);
            body1.Append(paragraph38);
            body1.Append(paragraph39);
            body1.Append(ClearencesPara);
            body1.Append(ClearencesParaText);
            //body1.Append(paragraph40);
            //body1.Append(paragraph41);
            //body1.Append(paragraph42);
            //body1.Append(paragraph43);
            body1.Append(prDrawSummaryExpPro);
            body1.Append(PrSumExpProExplained);
            body1.Append(paragraph46);
            //body1.Append(paragraph47);
            body1.Append(paragraph48);
            body1.Append(paragraph50);
            body1.Append(table4);
            body1.Append(BreakPage);

            body1.Append(paragraph66);
            body1.Append(paragraph67);
            body1.Append(paragraph68);
            foreach (var Exp in _Konsultant.ProfessionalExperience)
            {

                Table table5 = new Table();
                TableProperties tableProperties5 = new TableProperties();
                TableStyle tableStyle3 = new TableStyle() { Val = "Grilledutableau" };
                TableWidth tableWidth5 = new TableWidth() { Width = "10773", Type = TableWidthUnitValues.Dxa };
                TableCellSpacing tableCellSpacing1 = new TableCellSpacing() { Width = "1440", Type = TableWidthUnitValues.Nil };
                TableIndentation tableIndentation4 = new TableIndentation() { Width = -583, Type = TableWidthUnitValues.Dxa };

                TableBorders tableBorders4 = new TableBorders();
                TopBorder topBorder20 = new TopBorder() { Val = BorderValues.Outset, Color = "E7E6E6", ThemeColor = ThemeColorValues.Background2, Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                LeftBorder leftBorder19 = new LeftBorder() { Val = BorderValues.Outset, Color = "E7E6E6", ThemeColor = ThemeColorValues.Background2, Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                BottomBorder bottomBorder20 = new BottomBorder() { Val = BorderValues.Inset, Color = "E7E6E6", ThemeColor = ThemeColorValues.Background2, Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                RightBorder rightBorder7 = new RightBorder() { Val = BorderValues.Inset, Color = "E7E6E6", ThemeColor = ThemeColorValues.Background2, Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                InsideHorizontalBorder insideHorizontalBorder4 = new InsideHorizontalBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
                InsideVerticalBorder insideVerticalBorder4 = new InsideVerticalBorder() { Val = BorderValues.None, Color = "auto", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

                tableBorders4.Append(topBorder20);
                tableBorders4.Append(leftBorder19);
                tableBorders4.Append(bottomBorder20);
                tableBorders4.Append(rightBorder7);
                tableBorders4.Append(insideHorizontalBorder4);
                tableBorders4.Append(insideVerticalBorder4);
                TableLook tableLook5 = new TableLook() { Val = "04A0" };

                tableProperties5.Append(tableStyle3);
                tableProperties5.Append(tableWidth5);
                tableProperties5.Append(tableCellSpacing1);
                tableProperties5.Append(tableIndentation4);
                tableProperties5.Append(tableBorders4);
                tableProperties5.Append(tableLook5);

                TableGrid tableGrid5 = new TableGrid();
                GridColumn gridColumn12 = new GridColumn() { Width = "5615" };
                GridColumn gridColumn13 = new GridColumn() { Width = "5158" };

                tableGrid5.Append(gridColumn12);
                tableGrid5.Append(gridColumn13);

                TableRow tableRow14 = new TableRow() { RsidTableRowAddition = "006051D6", RsidTableRowProperties = "00954BC7" };

                TableRowProperties tableRowProperties14 = new TableRowProperties();
                TableRowHeight tableRowHeight14 = new TableRowHeight() { Val = (UInt32Value)320U };
                TableCellSpacing tableCellSpacing2 = new TableCellSpacing() { Width = "1440", Type = TableWidthUnitValues.Nil };

                tableRowProperties14.Append(tableRowHeight14);
                tableRowProperties14.Append(tableCellSpacing2);

                TableCell tableCell40 = new TableCell();

                TableCellProperties tableCellProperties40 = new TableCellProperties();
                TableCellWidth tableCellWidth40 = new TableCellWidth() { Width = "5552", Type = TableWidthUnitValues.Dxa };
                Shading shading27 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "auto" };

                tableCellProperties40.Append(tableCellWidth40);
                tableCellProperties40.Append(shading27);

                Paragraph paragraph69 = new Paragraph() { RsidParagraphMarkRevision = "00A902C9", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "00954BC7", RsidRunAdditionDefault = "00DB7D4C" };

                ParagraphProperties paragraphProperties65 = new ParagraphProperties();

                Tabs tabs21 = new Tabs();
                TabStop tabStop21 = new TabStop() { Val = TabStopValues.Left, Position = 142 };
                TabStop tabStop22 = new TabStop() { Val = TabStopValues.Left, Position = 1134 };

                tabs21.Append(tabStop21);
                tabs21.Append(tabStop22);
                AutoSpaceDE autoSpaceDE1 = new AutoSpaceDE() { Val = false };
                AutoSpaceDN autoSpaceDN1 = new AutoSpaceDN() { Val = false };
                AdjustRightIndent adjustRightIndent1 = new AdjustRightIndent() { Val = false };
                Indentation indentation9 = new Indentation() { End = "-1134" };

                ParagraphMarkRunProperties paragraphMarkRunProperties61 = new ParagraphMarkRunProperties();
                RunFonts runFonts138 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                Bold bold36 = new Bold();
                FontSize fontSize144 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript138 = new FontSizeComplexScript() { Val = "20" };

                paragraphMarkRunProperties61.Append(runFonts138);
                paragraphMarkRunProperties61.Append(bold36);
                paragraphMarkRunProperties61.Append(fontSize144);
                paragraphMarkRunProperties61.Append(fontSizeComplexScript138);

                paragraphProperties65.Append(tabs21);
                paragraphProperties65.Append(autoSpaceDE1);
                paragraphProperties65.Append(autoSpaceDN1);
                paragraphProperties65.Append(adjustRightIndent1);
                paragraphProperties65.Append(indentation9);
                paragraphProperties65.Append(paragraphMarkRunProperties61);
                ProofError proofError31 = new ProofError() { Type = ProofingErrorValues.SpellStart };

                Run run125 = new Run();

                RunProperties runProperties123 = new RunProperties();
                RunFonts runFonts139 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                Bold bold37 = new Bold();
                FontSize fontSize145 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript139 = new FontSizeComplexScript() { Val = "20" };

                runProperties123.Append(runFonts139);
                runProperties123.Append(bold37);
                runProperties123.Append(fontSize145);
                runProperties123.Append(fontSizeComplexScript139);
                Text text84 = new Text();
                text84.Text = $"From {Exp.StartDate.ToShortDateString()} till {Exp.EndDate.ToShortDateString()}";

                run125.Append(runProperties123);
                run125.Append(text84);
                ProofError proofError32 = new ProofError() { Type = ProofingErrorValues.SpellEnd };


                paragraph69.Append(paragraphProperties65);
                paragraph69.Append(proofError31);
                paragraph69.Append(run125);
                paragraph69.Append(proofError32);

                tableCell40.Append(tableCellProperties40);
                tableCell40.Append(paragraph69);

                TableCell tableCell41 = new TableCell();

                TableCellProperties tableCellProperties41 = new TableCellProperties();
                TableCellWidth tableCellWidth41 = new TableCellWidth() { Width = "5101", Type = TableWidthUnitValues.Dxa };
                Shading shading28 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "auto" };

                tableCellProperties41.Append(tableCellWidth41);
                tableCellProperties41.Append(shading28);

                Paragraph paragraph70 = new Paragraph() { RsidParagraphMarkRevision = "00481EF5", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "00954BC7", RsidRunAdditionDefault = "006051D6" };

                ParagraphProperties paragraphProperties66 = new ParagraphProperties();

                Tabs tabs22 = new Tabs();
                TabStop tabStop23 = new TabStop() { Val = TabStopValues.Left, Position = 142 };
                TabStop tabStop24 = new TabStop() { Val = TabStopValues.Left, Position = 1134 };

                tabs22.Append(tabStop23);
                tabs22.Append(tabStop24);
                AutoSpaceDE autoSpaceDE2 = new AutoSpaceDE() { Val = false };
                AutoSpaceDN autoSpaceDN2 = new AutoSpaceDN() { Val = false };
                AdjustRightIndent adjustRightIndent2 = new AdjustRightIndent() { Val = false };
                Indentation indentation10 = new Indentation() { End = "-1134" };

                ParagraphMarkRunProperties paragraphMarkRunProperties62 = new ParagraphMarkRunProperties();
                RunFonts runFonts150 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                Bold bold48 = new Bold();
                FontSize fontSize156 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript150 = new FontSizeComplexScript() { Val = "20" };
                Languages languages112 = new Languages() { Val = "en-GB" };

                paragraphMarkRunProperties62.Append(runFonts150);
                paragraphMarkRunProperties62.Append(bold48);
                paragraphMarkRunProperties62.Append(fontSize156);
                paragraphMarkRunProperties62.Append(fontSizeComplexScript150);
                paragraphMarkRunProperties62.Append(languages112);

                paragraphProperties66.Append(tabs22);
                paragraphProperties66.Append(autoSpaceDE2);
                paragraphProperties66.Append(autoSpaceDN2);
                paragraphProperties66.Append(adjustRightIndent2);
                paragraphProperties66.Append(indentation10);
                paragraphProperties66.Append(paragraphMarkRunProperties62);

                Run run136 = new Run() { RsidRunProperties = "00481EF5" };

                RunProperties runProperties134 = new RunProperties();
                RunFonts runFonts151 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Arial Unicode MS", ComplexScript = "Arial" };
                Bold bold49 = new Bold();
                FontSize fontSize157 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript151 = new FontSizeComplexScript() { Val = "20" };
                Languages languages113 = new Languages() { Val = "en-GB" };

                runProperties134.Append(runFonts151);
                runProperties134.Append(bold49);
                runProperties134.Append(fontSize157);
                runProperties134.Append(fontSizeComplexScript151);
                runProperties134.Append(languages113);
                Text text95 = new Text();
                text95.Text = $"{Exp.Customer} - {Exp.Position}";

                run136.Append(runProperties134);
                run136.Append(text95);


                paragraph70.Append(paragraphProperties66);
                paragraph70.Append(run136);

                tableCell41.Append(tableCellProperties41);
                tableCell41.Append(paragraph70);

                tableRow14.Append(tableRowProperties14);
                tableRow14.Append(tableCell40);
                tableRow14.Append(tableCell41);

                table5.Append(tableProperties5);
                table5.Append(tableGrid5);
                table5.Append(tableRow14);

                body1.Append(table5);


                Paragraph paragraph73 = new Paragraph() { RsidParagraphAddition = "00990EF5", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "00990EF5" };

                ParagraphProperties paragraphProperties69 = new ParagraphProperties();
                ParagraphStyleId paragraphStyleId23 = new ParagraphStyleId() { Val = "Puce1SMT" };

                NumberingProperties numberingProperties1 = new NumberingProperties();
                NumberingLevelReference numberingLevelReference1 = new NumberingLevelReference() { Val = 0 };
                NumberingId numberingId1 = new NumberingId() { Val = 0 };

                numberingProperties1.Append(numberingLevelReference1);
                numberingProperties1.Append(numberingId1);

                Tabs tabs25 = new Tabs();
                TabStop tabStop29 = new TabStop() { Val = TabStopValues.Left, Position = 708 };
                TabStop tabStop30 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

                tabs25.Append(tabStop29);
                tabs25.Append(tabStop30);
                OutlineLevel outlineLevel1 = new OutlineLevel() { Val = 0 };

                ParagraphMarkRunProperties paragraphMarkRunProperties65 = new ParagraphMarkRunProperties();
                RunFonts runFonts156 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                Bold bold54 = new Bold();
                Italic italic46 = new Italic() { Val = false };
                Color color72 = new Color() { Val = "000000", ThemeColor = ThemeColorValues.Text1 };
                FontSizeComplexScript fontSizeComplexScript156 = new FontSizeComplexScript() { Val = "20" };
                Languages languages118 = new Languages() { Val = "en-GB" };

                paragraphMarkRunProperties65.Append(runFonts156);
                paragraphMarkRunProperties65.Append(bold54);
                paragraphMarkRunProperties65.Append(italic46);
                paragraphMarkRunProperties65.Append(color72);
                paragraphMarkRunProperties65.Append(fontSizeComplexScript156);
                paragraphMarkRunProperties65.Append(languages118);

                paragraphProperties69.Append(paragraphStyleId23);
                paragraphProperties69.Append(numberingProperties1);
                paragraphProperties69.Append(tabs25);
                paragraphProperties69.Append(outlineLevel1);
                paragraphProperties69.Append(paragraphMarkRunProperties65);

                paragraph73.Append(paragraphProperties69);

                Paragraph paragraph74 = new Paragraph() { RsidParagraphMarkRevision = "00797275", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "006051D6" };

                ParagraphProperties paragraphProperties70 = new ParagraphProperties();
                ParagraphStyleId paragraphStyleId24 = new ParagraphStyleId() { Val = "Puce1SMT" };

                NumberingProperties numberingProperties2 = new NumberingProperties();
                NumberingLevelReference numberingLevelReference2 = new NumberingLevelReference() { Val = 0 };
                NumberingId numberingId2 = new NumberingId() { Val = 0 };

                numberingProperties2.Append(numberingLevelReference2);
                numberingProperties2.Append(numberingId2);

                Tabs tabs26 = new Tabs();
                TabStop tabStop31 = new TabStop() { Val = TabStopValues.Left, Position = 708 };
                TabStop tabStop32 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

                tabs26.Append(tabStop31);
                tabs26.Append(tabStop32);
                OutlineLevel outlineLevel2 = new OutlineLevel() { Val = 0 };

                ParagraphMarkRunProperties paragraphMarkRunProperties66 = new ParagraphMarkRunProperties();
                RunFonts runFonts157 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                Bold bold55 = new Bold();
                Italic italic47 = new Italic() { Val = false };
                Color color73 = new Color() { Val = "000000", ThemeColor = ThemeColorValues.Text1 };
                FontSize fontSize162 = new FontSize() { Val = "22" };
                FontSizeComplexScript fontSizeComplexScript157 = new FontSizeComplexScript() { Val = "20" };
                Languages languages119 = new Languages() { Val = "en-GB" };

                paragraphMarkRunProperties66.Append(runFonts157);
                paragraphMarkRunProperties66.Append(bold55);
                paragraphMarkRunProperties66.Append(italic47);
                paragraphMarkRunProperties66.Append(color73);
                paragraphMarkRunProperties66.Append(fontSize162);
                paragraphMarkRunProperties66.Append(fontSizeComplexScript157);
                paragraphMarkRunProperties66.Append(languages119);

                paragraphProperties70.Append(paragraphStyleId24);
                paragraphProperties70.Append(numberingProperties2);
                paragraphProperties70.Append(tabs26);
                paragraphProperties70.Append(outlineLevel2);
                paragraphProperties70.Append(paragraphMarkRunProperties66);

                Run run139 = new Run() { RsidRunProperties = "00797275" };

                RunProperties runProperties137 = new RunProperties();
                RunFonts runFonts158 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                Bold bold56 = new Bold();
                Italic italic48 = new Italic() { Val = false };
                Color color74 = new Color() { Val = "000000", ThemeColor = ThemeColorValues.Text1 };
                FontSizeComplexScript fontSizeComplexScript158 = new FontSizeComplexScript() { Val = "20" };
                Languages languages120 = new Languages() { Val = "en-GB" };

                runProperties137.Append(runFonts158);
                runProperties137.Append(bold56);
                runProperties137.Append(italic48);
                runProperties137.Append(color74);
                runProperties137.Append(fontSizeComplexScript158);
                runProperties137.Append(languages120);
                Text text98 = new Text();
                text98.Text = "Role";

                run139.Append(runProperties137);
                run139.Append(text98);

                Run run140 = new Run() { RsidRunProperties = "00797275" };

                RunProperties runProperties138 = new RunProperties();
                RunFonts runFonts159 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                Bold bold57 = new Bold();
                Italic italic49 = new Italic() { Val = false };
                Color color75 = new Color() { Val = "000000", ThemeColor = ThemeColorValues.Text1 };
                FontSize fontSize163 = new FontSize() { Val = "22" };
                FontSizeComplexScript fontSizeComplexScript159 = new FontSizeComplexScript() { Val = "20" };
                Languages languages121 = new Languages() { Val = "en-GB" };

                runProperties138.Append(runFonts159);
                runProperties138.Append(bold57);
                runProperties138.Append(italic49);
                runProperties138.Append(color75);
                runProperties138.Append(fontSize163);
                runProperties138.Append(fontSizeComplexScript159);
                runProperties138.Append(languages121);
                Text text99 = new Text() { Space = SpaceProcessingModeValues.Preserve };
                text99.Text = $": {Exp.Position}";

                run140.Append(runProperties138);
                run140.Append(text99);

                //Run run141 = new Run() { RsidRunProperties = "00797275" };

                //RunProperties runProperties139 = new RunProperties();
                //RunFonts runFonts160 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                //Bold bold58 = new Bold();
                //Italic italic50 = new Italic() { Val = false };
                //Color color76 = new Color() { Val = "000000", ThemeColor = ThemeColorValues.Text1 };
                //FontSizeComplexScript fontSizeComplexScript160 = new FontSizeComplexScript() { Val = "20" };
                //Languages languages122 = new Languages() { Val = "en-GB" };

                //runProperties139.Append(runFonts160);
                //runProperties139.Append(bold58);
                //runProperties139.Append(italic50);
                //runProperties139.Append(color76);
                //runProperties139.Append(fontSizeComplexScript160);
                //runProperties139.Append(languages122);
                //Text text100 = new Text();
                //text100.Text = "Name of the position";

                //run141.Append(runProperties139);
                //run141.Append(text100);

                Run run142 = new Run() { RsidRunProperties = "00797275" };

                RunProperties runProperties140 = new RunProperties();
                RunFonts runFonts161 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                Bold bold59 = new Bold();
                Italic italic51 = new Italic() { Val = false };
                Color color77 = new Color() { Val = "000000", ThemeColor = ThemeColorValues.Text1 };
                FontSize fontSize164 = new FontSize() { Val = "22" };
                FontSizeComplexScript fontSizeComplexScript161 = new FontSizeComplexScript() { Val = "20" };
                Languages languages123 = new Languages() { Val = "en-GB" };

                runProperties140.Append(runFonts161);
                runProperties140.Append(bold59);
                runProperties140.Append(italic51);
                runProperties140.Append(color77);
                runProperties140.Append(fontSize164);
                runProperties140.Append(fontSizeComplexScript161);
                runProperties140.Append(languages123);
                Text text101 = new Text() { Space = SpaceProcessingModeValues.Preserve };
                text101.Text = "  ";

                run142.Append(runProperties140);
                run142.Append(text101);

                paragraph74.Append(paragraphProperties70);
                paragraph74.Append(run139);
                paragraph74.Append(run140);
                //paragraph74.Append(run141);
                paragraph74.Append(run142);

                Paragraph paragraph75 = new Paragraph() { RsidParagraphMarkRevision = "00797275", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "006051D6" };

                ParagraphProperties paragraphProperties71 = new ParagraphProperties();
                ParagraphStyleId paragraphStyleId25 = new ParagraphStyleId() { Val = "Puce1SMT" };

                NumberingProperties numberingProperties3 = new NumberingProperties();
                NumberingLevelReference numberingLevelReference3 = new NumberingLevelReference() { Val = 0 };
                NumberingId numberingId3 = new NumberingId() { Val = 0 };

                numberingProperties3.Append(numberingLevelReference3);
                numberingProperties3.Append(numberingId3);

                Tabs tabs27 = new Tabs();
                TabStop tabStop33 = new TabStop() { Val = TabStopValues.Left, Position = 708 };
                TabStop tabStop34 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

                tabs27.Append(tabStop33);
                tabs27.Append(tabStop34);

                ParagraphMarkRunProperties paragraphMarkRunProperties67 = new ParagraphMarkRunProperties();
                RunFonts runFonts162 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                Bold bold60 = new Bold();
                Color color78 = new Color() { Val = "7F7F7F", ThemeColor = ThemeColorValues.Text1, ThemeTint = "80" };
                FontSizeComplexScript fontSizeComplexScript162 = new FontSizeComplexScript() { Val = "20" };
                Languages languages124 = new Languages() { Val = "en-GB" };

                paragraphMarkRunProperties67.Append(runFonts162);
                paragraphMarkRunProperties67.Append(bold60);
                paragraphMarkRunProperties67.Append(color78);
                paragraphMarkRunProperties67.Append(fontSizeComplexScript162);
                paragraphMarkRunProperties67.Append(languages124);

                paragraphProperties71.Append(paragraphStyleId25);
                paragraphProperties71.Append(numberingProperties3);
                paragraphProperties71.Append(tabs27);
                paragraphProperties71.Append(paragraphMarkRunProperties67);

                paragraph75.Append(paragraphProperties71);

                Paragraph paragraph76 = new Paragraph() { RsidParagraphMarkRevision = "00797275", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "006051D6" };

                ParagraphProperties paragraphProperties72 = new ParagraphProperties();

                Tabs tabs28 = new Tabs();
                TabStop tabStop35 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

                tabs28.Append(tabStop35);
                Justification justification16 = new Justification() { Val = JustificationValues.Both };

                ParagraphMarkRunProperties paragraphMarkRunProperties68 = new ParagraphMarkRunProperties();
                RunFonts runFonts163 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                BoldComplexScript boldComplexScript3 = new BoldComplexScript();
                Italic italic52 = new Italic();
                ItalicComplexScript italicComplexScript1 = new ItalicComplexScript();
                FontSize fontSize165 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript163 = new FontSizeComplexScript() { Val = "20" };
                Languages languages125 = new Languages() { EastAsia = "fr-FR" };

                paragraphMarkRunProperties68.Append(runFonts163);
                paragraphMarkRunProperties68.Append(boldComplexScript3);
                paragraphMarkRunProperties68.Append(italic52);
                paragraphMarkRunProperties68.Append(italicComplexScript1);
                paragraphMarkRunProperties68.Append(fontSize165);
                paragraphMarkRunProperties68.Append(fontSizeComplexScript163);
                paragraphMarkRunProperties68.Append(languages125);

                paragraphProperties72.Append(tabs28);
                paragraphProperties72.Append(justification16);
                paragraphProperties72.Append(paragraphMarkRunProperties68);

                Run run143 = new Run() { RsidRunProperties = "00797275" };

                RunProperties runProperties141 = new RunProperties();
                RunFonts runFonts164 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                BoldComplexScript boldComplexScript4 = new BoldComplexScript();
                Italic italic53 = new Italic();
                ItalicComplexScript italicComplexScript2 = new ItalicComplexScript();
                FontSize fontSize166 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript164 = new FontSizeComplexScript() { Val = "20" };
                Languages languages126 = new Languages() { EastAsia = "fr-FR" };

                runProperties141.Append(runFonts164);
                runProperties141.Append(boldComplexScript4);
                runProperties141.Append(italic53);
                runProperties141.Append(italicComplexScript2);
                runProperties141.Append(fontSize166);
                runProperties141.Append(fontSizeComplexScript164);
                runProperties141.Append(languages126);
                Text text102 = new Text();
                text102.Text = $"{Exp.Summary}";

                run143.Append(runProperties141);
                run143.Append(text102);

                paragraph76.Append(paragraphProperties72);
                paragraph76.Append(run143);

                Paragraph paragraph77 = new Paragraph() { RsidParagraphMarkRevision = "00797275", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "006051D6" };

                ParagraphProperties paragraphProperties73 = new ParagraphProperties();

                Tabs tabs29 = new Tabs();
                TabStop tabStop36 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

                tabs29.Append(tabStop36);
                Indentation indentation13 = new Indentation() { Start = "1985", Hanging = "2" };
                Justification justification17 = new Justification() { Val = JustificationValues.Both };

                ParagraphMarkRunProperties paragraphMarkRunProperties69 = new ParagraphMarkRunProperties();
                RunFonts runFonts165 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                BoldComplexScript boldComplexScript5 = new BoldComplexScript();
                Italic italic54 = new Italic();
                ItalicComplexScript italicComplexScript3 = new ItalicComplexScript();
                FontSize fontSize167 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript165 = new FontSizeComplexScript() { Val = "20" };
                Languages languages127 = new Languages() { EastAsia = "fr-FR" };

                paragraphMarkRunProperties69.Append(runFonts165);
                paragraphMarkRunProperties69.Append(boldComplexScript5);
                paragraphMarkRunProperties69.Append(italic54);
                paragraphMarkRunProperties69.Append(italicComplexScript3);
                paragraphMarkRunProperties69.Append(fontSize167);
                paragraphMarkRunProperties69.Append(fontSizeComplexScript165);
                paragraphMarkRunProperties69.Append(languages127);

                paragraphProperties73.Append(tabs29);
                paragraphProperties73.Append(indentation13);
                paragraphProperties73.Append(justification17);
                paragraphProperties73.Append(paragraphMarkRunProperties69);

                paragraph77.Append(paragraphProperties73);

                Paragraph paragraph78 = new Paragraph() { RsidParagraphMarkRevision = "00797275", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "006051D6" };

                ParagraphProperties paragraphProperties74 = new ParagraphProperties();

                Tabs tabs30 = new Tabs();
                TabStop tabStop37 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

                tabs30.Append(tabStop37);
                Justification justification18 = new Justification() { Val = JustificationValues.Both };

                ParagraphMarkRunProperties paragraphMarkRunProperties70 = new ParagraphMarkRunProperties();
                RunFonts runFonts166 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                Bold bold61 = new Bold();
                BoldComplexScript boldComplexScript6 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript4 = new ItalicComplexScript();
                FontSize fontSize168 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript166 = new FontSizeComplexScript() { Val = "20" };
                Languages languages128 = new Languages() { EastAsia = "fr-FR" };

                paragraphMarkRunProperties70.Append(runFonts166);
                paragraphMarkRunProperties70.Append(bold61);
                paragraphMarkRunProperties70.Append(boldComplexScript6);
                paragraphMarkRunProperties70.Append(italicComplexScript4);
                paragraphMarkRunProperties70.Append(fontSize168);
                paragraphMarkRunProperties70.Append(fontSizeComplexScript166);
                paragraphMarkRunProperties70.Append(languages128);

                paragraphProperties74.Append(tabs30);
                paragraphProperties74.Append(justification18);
                paragraphProperties74.Append(paragraphMarkRunProperties70);

                Run run144 = new Run() { RsidRunProperties = "00797275" };

                RunProperties runProperties142 = new RunProperties();
                RunFonts runFonts167 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                Bold bold62 = new Bold();
                BoldComplexScript boldComplexScript7 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript5 = new ItalicComplexScript();
                FontSize fontSize169 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript167 = new FontSizeComplexScript() { Val = "20" };
                Languages languages129 = new Languages() { EastAsia = "fr-FR" };

                runProperties142.Append(runFonts167);
                runProperties142.Append(bold62);
                runProperties142.Append(boldComplexScript7);
                runProperties142.Append(italicComplexScript5);
                runProperties142.Append(fontSize169);
                runProperties142.Append(fontSizeComplexScript167);
                runProperties142.Append(languages129);
                Text text103 = new Text();
                text103.Text = "Detail of accomplishments ";

                run144.Append(runProperties142);
                run144.Append(text103);

                Run run145 = new Run() { RsidRunProperties = "00797275" };

                RunProperties runProperties143 = new RunProperties();
                RunFonts runFonts168 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                BoldComplexScript boldComplexScript8 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript6 = new ItalicComplexScript();
                FontSize fontSize170 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript168 = new FontSizeComplexScript() { Val = "20" };
                Languages languages130 = new Languages() { EastAsia = "fr-FR" };

                runProperties143.Append(runFonts168);
                runProperties143.Append(boldComplexScript8);
                runProperties143.Append(italicComplexScript6);
                runProperties143.Append(fontSize170);
                runProperties143.Append(fontSizeComplexScript168);
                runProperties143.Append(languages130);
                Text text104 = new Text();
                text104.Text = "(technical, functional, other)";

                run145.Append(runProperties143);
                run145.Append(text104);

                paragraph78.Append(paragraphProperties74);
                paragraph78.Append(run144);
                paragraph78.Append(run145);
                Paragraph paragraph79 = new Paragraph() { RsidParagraphMarkRevision = "006A08FF", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "006051D6" };

                //Loop here on Accomplishments.
                foreach (var achievments in Exp.Accomplishment)
                {

                    ParagraphProperties paragraphProperties75 = new ParagraphProperties();

                    Tabs tabs31 = new Tabs();
                    TabStop tabStop38 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

                    tabs31.Append(tabStop38);
                    Indentation indentation14 = new Indentation() { Start = "710", Hanging = "2" };
                    Justification justification19 = new Justification() { Val = JustificationValues.Both };

                    ParagraphMarkRunProperties paragraphMarkRunProperties71 = new ParagraphMarkRunProperties();
                    RunFonts runFonts169 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                    BoldComplexScript boldComplexScript9 = new BoldComplexScript();
                    ItalicComplexScript italicComplexScript7 = new ItalicComplexScript();
                    FontSize fontSize171 = new FontSize() { Val = "20" };
                    FontSizeComplexScript fontSizeComplexScript169 = new FontSizeComplexScript() { Val = "20" };
                    Languages languages131 = new Languages() { EastAsia = "fr-FR" };

                    paragraphMarkRunProperties71.Append(runFonts169);
                    paragraphMarkRunProperties71.Append(boldComplexScript9);
                    paragraphMarkRunProperties71.Append(italicComplexScript7);
                    paragraphMarkRunProperties71.Append(fontSize171);
                    paragraphMarkRunProperties71.Append(fontSizeComplexScript169);
                    paragraphMarkRunProperties71.Append(languages131);

                    paragraphProperties75.Append(tabs31);
                    paragraphProperties75.Append(indentation14);
                    paragraphProperties75.Append(justification19);
                    paragraphProperties75.Append(paragraphMarkRunProperties71);

                    Run run146 = new Run() { RsidRunProperties = "006A08FF" };

                    RunProperties runProperties144 = new RunProperties();
                    RunFonts runFonts170 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                    BoldComplexScript boldComplexScript10 = new BoldComplexScript();
                    ItalicComplexScript italicComplexScript8 = new ItalicComplexScript();
                    FontSize fontSize172 = new FontSize() { Val = "20" };
                    FontSizeComplexScript fontSizeComplexScript170 = new FontSizeComplexScript() { Val = "20" };
                    Languages languages132 = new Languages() { EastAsia = "fr-FR" };

                    runProperties144.Append(runFonts170);
                    runProperties144.Append(boldComplexScript10);
                    runProperties144.Append(italicComplexScript8);
                    runProperties144.Append(fontSize172);
                    runProperties144.Append(fontSizeComplexScript170);
                    runProperties144.Append(languages132);
                    Text text105 = new Text();
                    text105.Text = $" {achievments.Title}";

                    run146.Append(runProperties144);
                    run146.Append(text105);
                    run146.Append(new Break());
                    paragraph79.Append(paragraphProperties75);
                    paragraph79.Append(run146);
                }

                Paragraph paragraph82 = new Paragraph() { RsidParagraphMarkRevision = "006A08FF", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "006051D6" };

                ParagraphProperties paragraphProperties78 = new ParagraphProperties();

                Tabs tabs34 = new Tabs();
                TabStop tabStop41 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

                tabs34.Append(tabStop41);
                Justification justification22 = new Justification() { Val = JustificationValues.Both };
                OutlineLevel outlineLevel3 = new OutlineLevel() { Val = 0 };

                ParagraphMarkRunProperties paragraphMarkRunProperties74 = new ParagraphMarkRunProperties();
                RunFonts runFonts175 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                BoldComplexScript boldComplexScript15 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript13 = new ItalicComplexScript();
                FontSize fontSize177 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript175 = new FontSizeComplexScript() { Val = "20" };
                Languages languages137 = new Languages() { EastAsia = "fr-FR" };

                paragraphMarkRunProperties74.Append(runFonts175);
                paragraphMarkRunProperties74.Append(boldComplexScript15);
                paragraphMarkRunProperties74.Append(italicComplexScript13);
                paragraphMarkRunProperties74.Append(fontSize177);
                paragraphMarkRunProperties74.Append(fontSizeComplexScript175);
                paragraphMarkRunProperties74.Append(languages137);

                paragraphProperties78.Append(tabs34);
                paragraphProperties78.Append(justification22);
                paragraphProperties78.Append(outlineLevel3);
                paragraphProperties78.Append(paragraphMarkRunProperties74);

                Run run149 = new Run();

                RunProperties runProperties147 = new RunProperties();
                RunFonts runFonts176 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                Bold bold63 = new Bold();
                BoldComplexScript boldComplexScript16 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript14 = new ItalicComplexScript();
                FontSize fontSize178 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript176 = new FontSizeComplexScript() { Val = "20" };
                Languages languages138 = new Languages() { EastAsia = "fr-FR" };

                runProperties147.Append(runFonts176);
                runProperties147.Append(bold63);
                runProperties147.Append(boldComplexScript16);
                runProperties147.Append(italicComplexScript14);
                runProperties147.Append(fontSize178);
                runProperties147.Append(fontSizeComplexScript176);
                runProperties147.Append(languages138);
                Text text108 = new Text();
                text108.Text = "T";

                run149.Append(runProperties147);
                run149.Append(text108);

                Run run150 = new Run() { RsidRunProperties = "006A08FF" };

                RunProperties runProperties148 = new RunProperties();
                RunFonts runFonts177 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                Bold bold64 = new Bold();
                BoldComplexScript boldComplexScript17 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript15 = new ItalicComplexScript();
                FontSize fontSize179 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript177 = new FontSizeComplexScript() { Val = "20" };
                Languages languages139 = new Languages() { EastAsia = "fr-FR" };

                runProperties148.Append(runFonts177);
                runProperties148.Append(bold64);
                runProperties148.Append(boldComplexScript17);
                runProperties148.Append(italicComplexScript15);
                runProperties148.Append(fontSize179);
                runProperties148.Append(fontSizeComplexScript177);
                runProperties148.Append(languages139);
                Text text109 = new Text();
                text109.Text = "echni";

                run150.Append(runProperties148);
                run150.Append(text109);

                Run run151 = new Run();

                RunProperties runProperties149 = new RunProperties();
                RunFonts runFonts178 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                Bold bold65 = new Bold();
                BoldComplexScript boldComplexScript18 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript16 = new ItalicComplexScript();
                FontSize fontSize180 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript178 = new FontSizeComplexScript() { Val = "20" };
                Languages languages140 = new Languages() { EastAsia = "fr-FR" };

                runProperties149.Append(runFonts178);
                runProperties149.Append(bold65);
                runProperties149.Append(boldComplexScript18);
                runProperties149.Append(italicComplexScript16);
                runProperties149.Append(fontSize180);
                runProperties149.Append(fontSizeComplexScript178);
                runProperties149.Append(languages140);
                Text text110 = new Text();
                text110.Text = "cal";

                run151.Append(runProperties149);
                run151.Append(text110);

                Run run152 = new Run() { RsidRunProperties = "006A08FF" };

                RunProperties runProperties150 = new RunProperties();
                RunFonts runFonts179 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                Bold bold66 = new Bold();
                BoldComplexScript boldComplexScript19 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript17 = new ItalicComplexScript();
                FontSize fontSize181 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript179 = new FontSizeComplexScript() { Val = "20" };
                Languages languages141 = new Languages() { EastAsia = "fr-FR" };

                runProperties150.Append(runFonts179);
                runProperties150.Append(bold66);
                runProperties150.Append(boldComplexScript19);
                runProperties150.Append(italicComplexScript17);
                runProperties150.Append(fontSize181);
                runProperties150.Append(fontSizeComplexScript179);
                runProperties150.Append(languages141);
                Text text111 = new Text();
                text111.Text = " ";

                run152.Append(runProperties150);
                run152.Append(text111);

                Run run153 = new Run();

                RunProperties runProperties151 = new RunProperties();
                RunFonts runFonts180 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                Bold bold67 = new Bold();
                BoldComplexScript boldComplexScript20 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript18 = new ItalicComplexScript();
                FontSize fontSize182 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript180 = new FontSizeComplexScript() { Val = "20" };
                Languages languages142 = new Languages() { EastAsia = "fr-FR" };

                runProperties151.Append(runFonts180);
                runProperties151.Append(bold67);
                runProperties151.Append(boldComplexScript20);
                runProperties151.Append(italicComplexScript18);
                runProperties151.Append(fontSize182);
                runProperties151.Append(fontSizeComplexScript180);
                runProperties151.Append(languages142);
                Text text112 = new Text();
                text112.Text = "e";

                run153.Append(runProperties151);
                run153.Append(text112);

                Run run154 = new Run() { RsidRunProperties = "006A08FF" };

                RunProperties runProperties152 = new RunProperties();
                RunFonts runFonts181 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                Bold bold68 = new Bold();
                BoldComplexScript boldComplexScript21 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript19 = new ItalicComplexScript();
                FontSize fontSize183 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript181 = new FontSizeComplexScript() { Val = "20" };
                Languages languages143 = new Languages() { EastAsia = "fr-FR" };

                runProperties152.Append(runFonts181);
                runProperties152.Append(bold68);
                runProperties152.Append(boldComplexScript21);
                runProperties152.Append(italicComplexScript19);
                runProperties152.Append(fontSize183);
                runProperties152.Append(fontSizeComplexScript181);
                runProperties152.Append(languages143);
                Text text113 = new Text();
                text113.Text = "nvironment";

                run154.Append(runProperties152);
                run154.Append(text113);

                Run run155 = new Run() { RsidRunProperties = "006A08FF" };

                RunProperties runProperties153 = new RunProperties();
                RunFonts runFonts182 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                BoldComplexScript boldComplexScript22 = new BoldComplexScript();
                ItalicComplexScript italicComplexScript20 = new ItalicComplexScript();
                FontSize fontSize184 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript182 = new FontSizeComplexScript() { Val = "20" };
                Languages languages144 = new Languages() { EastAsia = "fr-FR" };

                runProperties153.Append(runFonts182);
                runProperties153.Append(boldComplexScript22);
                runProperties153.Append(italicComplexScript20);
                runProperties153.Append(fontSize184);
                runProperties153.Append(fontSizeComplexScript182);
                runProperties153.Append(languages144);
                Text text114 = new Text();
                text114.Text = ":";

                run155.Append(runProperties153);
                run155.Append(text114);

                paragraph82.Append(paragraphProperties78);
                paragraph82.Append(run149);
                paragraph82.Append(run150);
                paragraph82.Append(run151);
                paragraph82.Append(run152);
                paragraph82.Append(run153);
                paragraph82.Append(run154);
                paragraph82.Append(run155);

                Paragraph paragraph83 = new Paragraph() { RsidParagraphMarkRevision = "006A08FF", RsidParagraphAddition = "006051D6", RsidParagraphProperties = "006051D6", RsidRunAdditionDefault = "006051D6" };
                foreach (var technical in Exp.TechnicalEnvironment)
                {
                    ParagraphProperties paragraphProperties79 = new ParagraphProperties();

                    Tabs tabs35 = new Tabs();
                    TabStop tabStop42 = new TabStop() { Val = TabStopValues.Left, Position = 1985 };

                    tabs35.Append(tabStop42);
                    Indentation indentation17 = new Indentation() { Start = "710", Hanging = "2" };
                    Justification justification23 = new Justification() { Val = JustificationValues.Both };

                    ParagraphMarkRunProperties paragraphMarkRunProperties75 = new ParagraphMarkRunProperties();
                    RunFonts runFonts183 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                    BoldComplexScript boldComplexScript23 = new BoldComplexScript();
                    ItalicComplexScript italicComplexScript21 = new ItalicComplexScript();
                    FontSize fontSize185 = new FontSize() { Val = "20" };
                    FontSizeComplexScript fontSizeComplexScript183 = new FontSizeComplexScript() { Val = "20" };
                    Languages languages145 = new Languages() { EastAsia = "fr-FR" };

                    paragraphMarkRunProperties75.Append(runFonts183);
                    paragraphMarkRunProperties75.Append(boldComplexScript23);
                    paragraphMarkRunProperties75.Append(italicComplexScript21);
                    paragraphMarkRunProperties75.Append(fontSize185);
                    paragraphMarkRunProperties75.Append(fontSizeComplexScript183);
                    paragraphMarkRunProperties75.Append(languages145);

                    paragraphProperties79.Append(tabs35);
                    paragraphProperties79.Append(indentation17);
                    paragraphProperties79.Append(justification23);
                    paragraphProperties79.Append(paragraphMarkRunProperties75);

                    Run run156 = new Run() { RsidRunProperties = "006A08FF" };

                    RunProperties runProperties154 = new RunProperties();
                    RunFonts runFonts184 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", EastAsia = "Times New Roman", ComplexScript = "Arial" };
                    BoldComplexScript boldComplexScript24 = new BoldComplexScript();
                    ItalicComplexScript italicComplexScript22 = new ItalicComplexScript();
                    FontSize fontSize186 = new FontSize() { Val = "20" };
                    FontSizeComplexScript fontSizeComplexScript184 = new FontSizeComplexScript() { Val = "20" };
                    Languages languages146 = new Languages() { EastAsia = "fr-FR" };

                    runProperties154.Append(runFonts184);
                    runProperties154.Append(boldComplexScript24);
                    runProperties154.Append(italicComplexScript22);
                    runProperties154.Append(fontSize186);
                    runProperties154.Append(fontSizeComplexScript184);
                    runProperties154.Append(languages146);
                    Text text115 = new Text();
                    text115.Text = $"{technical.Name}";

                    run156.Append(runProperties154);
                    run156.Append(text115);
                    run156.Append(new Break());

                    paragraph83.Append(paragraphProperties79);
                    paragraph83.Append(run156);
                }


                body1.Append(paragraph73);
                body1.Append(paragraph74);
                body1.Append(paragraph75);
                body1.Append(paragraph76);
                body1.Append(paragraph77);


                //Achivment
                if (Exp.Accomplishment.Any())
                {
                    body1.Append(paragraph78);
                    body1.Append(paragraph79);
                }

                if (Exp.TechnicalEnvironment.Any())
                {
                    body1.Append(paragraph82);
                    body1.Append(paragraph83);
                }


            }


            body1.Append(paragraph86);
            body1.Append(paragraph87);
            body1.Append(paragraph88);
            body1.Append(paragraph90);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            mainDocumentPart1.Document = document1;
        }
    }
}
