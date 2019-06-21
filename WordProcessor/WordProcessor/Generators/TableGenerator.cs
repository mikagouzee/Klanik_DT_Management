using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.Linq;
using WordProcessor.Ext;

namespace WordProcessor.Generators {
    class TableGenerator {
        public Table GenerateSkillsTable(Table inTable, List<OwnedCompetence> skills)
        {
            Table table1 = inTable;

            TableProperties tableProperties1 = new TableProperties();
            TableStyle tableStyle1 = new TableStyle() { Val = "7" };
            TableWidth tableWidth1 = new TableWidth() { Width = "10264", Type = TableWidthUnitValues.Dxa };
            TableIndentation tableIndentation1 = new TableIndentation() { Width = -147, Type = TableWidthUnitValues.Dxa };
            TableLayout tableLayout1 = new TableLayout() { Type = TableLayoutValues.Fixed };

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TopMargin topMargin1 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin1 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(topMargin1);
            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(bottomMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);

            tableProperties1.Append(tableStyle1);
            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableIndentation1);
            tableProperties1.Append(tableLayout1);
            tableProperties1.Append(tableCellMarginDefault1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn() { Width = "3796" };
            GridColumn gridColumn2 = new GridColumn() { Width = "1200" };
            GridColumn gridColumn3 = new GridColumn() { Width = "4148" };
            GridColumn gridColumn4 = new GridColumn() { Width = "1120" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);
            tableGrid1.Append(gridColumn4);
            table1.Append(tableProperties1);

            foreach (var comp in skills.ChunksOf(2))
            {

                TableRow tableRow1 = new TableRow();

                TablePropertyExceptions tablePropertyExceptions1 = new TablePropertyExceptions();
                TableLayout tableLayout2 = new TableLayout() { Type = TableLayoutValues.Fixed };

                TableCellMarginDefault tableCellMarginDefault2 = new TableCellMarginDefault();
                TopMargin topMargin2 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
                TableCellLeftMargin tableCellLeftMargin2 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
                BottomMargin bottomMargin2 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
                TableCellRightMargin tableCellRightMargin2 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

                tableCellMarginDefault2.Append(topMargin2);
                tableCellMarginDefault2.Append(tableCellLeftMargin2);
                tableCellMarginDefault2.Append(bottomMargin2);
                tableCellMarginDefault2.Append(tableCellRightMargin2);

                tablePropertyExceptions1.Append(tableLayout2);
                tablePropertyExceptions1.Append(tableCellMarginDefault2);

                TableRowProperties tableRowProperties1 = new TableRowProperties();
                TableRowHeight tableRowHeight1 = new TableRowHeight() { Val = (UInt32Value)266U, HeightType = HeightRuleValues.AtLeast };

                tableRowProperties1.Append(tableRowHeight1);
                SymbolChar symbolChar = new SymbolChar();
                symbolChar.Char = "F0AB";
                symbolChar.Font = "Wingdings";
                //Even idx.
                #region Cell1
                TableCell tableCell1 = new TableCell();

                TableCellProperties tableCellProperties1 = new TableCellProperties();
                TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "3796", Type = TableWidthUnitValues.Dxa };

                TableCellBorders tableCellBorders1 = new TableCellBorders();
                TopBorder topBorder1 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                LeftBorder leftBorder1 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                BottomBorder bottomBorder1 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };

                tableCellBorders1.Append(topBorder1);
                tableCellBorders1.Append(leftBorder1);
                tableCellBorders1.Append(bottomBorder1);
                Shading shading1 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9E2F3", ThemeFill = ThemeColorValues.Accent1, ThemeFillTint = "33" };
                TableCellVerticalAlignment tableCellVerticalAlignment1 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

                tableCellProperties1.Append(tableCellWidth1);
                tableCellProperties1.Append(tableCellBorders1);
                tableCellProperties1.Append(shading1);
                tableCellProperties1.Append(tableCellVerticalAlignment1);
                Paragraph paragraph1 = new Paragraph();

                ParagraphProperties paragraphProperties1 = new ParagraphProperties();
                ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId() { Val = "14" };

                ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
                RunFonts runFonts1 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                FontSize fontSize1 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "20" };

                paragraphMarkRunProperties1.Append(runFonts1);
                paragraphMarkRunProperties1.Append(fontSize1);
                paragraphMarkRunProperties1.Append(fontSizeComplexScript1);

                paragraphProperties1.Append(paragraphStyleId1);
                paragraphProperties1.Append(paragraphMarkRunProperties1);

                paragraph1.Append(paragraphProperties1, new Run(new Text(comp[0].Competence.Name)));
                #endregion
                #region Cell2
                TableCell tableCell2 = new TableCell();

                TableCellProperties tableCellProperties2 = new TableCellProperties();
                TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "1200", Type = TableWidthUnitValues.Dxa };

                TableCellBorders tableCellBorders2 = new TableCellBorders();
                TopBorder topBorder2 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                LeftBorder leftBorder2 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                BottomBorder bottomBorder2 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };

                tableCellBorders2.Append(topBorder2);
                tableCellBorders2.Append(leftBorder2);
                tableCellBorders2.Append(bottomBorder2);
                Shading shading2 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9E2F3", ThemeFill = ThemeColorValues.Accent1, ThemeFillTint = "33" };
                TableCellVerticalAlignment tableCellVerticalAlignment2 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

                tableCellProperties2.Append(tableCellWidth2);
                tableCellProperties2.Append(tableCellBorders2);
                tableCellProperties2.Append(shading2);
                tableCellProperties2.Append(tableCellVerticalAlignment2);

                Paragraph paragraph2 = new Paragraph();

                ParagraphProperties paragraphProperties2 = new ParagraphProperties();
                ParagraphStyleId paragraphStyleId2 = new ParagraphStyleId() { Val = "14" };
                //ADD THE STAR HERE

                OpenXmlElement[] Stars = Enumerable.Range(0, comp[0].Rating).Select(x => symbolChar.CloneNode(true)).ToArray();
                RunProperties FristStarRunProperties = new RunProperties();
                FristStarRunProperties.RunFonts = new RunFonts { Ascii = "Arial", HighAnsi = "Arial" };
                FristStarRunProperties.FontSize = new FontSize { Val = "20" };
                Run StarRun = new Run(FristStarRunProperties);
                StarRun.Append(Stars);
                //
                ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
                RunFonts runFonts2 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                Bold bold1 = new Bold();
                Color color1 = new Color() { Val = "4F81BD" };
                FontSize fontSize2 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "20" };
                Shading shading3 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "FFFF00" };

                paragraphMarkRunProperties2.Append(runFonts2);
                paragraphMarkRunProperties2.Append(bold1);
                paragraphMarkRunProperties2.Append(color1);
                paragraphMarkRunProperties2.Append(fontSize2);
                paragraphMarkRunProperties2.Append(fontSizeComplexScript2);
                paragraphMarkRunProperties2.Append(shading3);

                paragraphProperties2.Append(paragraphStyleId2);
                paragraphProperties2.Append(paragraphMarkRunProperties2);

                paragraph2.Append(paragraphProperties2, StarRun);

                tableCell2.Append(tableCellProperties2);
                tableCell2.Append(paragraph2);
                tableCell1.Append(tableCellProperties1);
                tableCell1.Append(paragraph1);

                #endregion
                #region Cell3
                //Need a check here, if we are out of range or not.

                TableCell tableCell3 = new TableCell();

                TableCellProperties tableCellProperties3 = new TableCellProperties();
                TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "4148", Type = TableWidthUnitValues.Dxa };

                TableCellBorders tableCellBorders3 = new TableCellBorders();
                TopBorder topBorder3 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                LeftBorder leftBorder3 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)40U, Space = (UInt32Value)0U };
                BottomBorder bottomBorder3 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };

                tableCellBorders3.Append(topBorder3);
                tableCellBorders3.Append(leftBorder3);
                tableCellBorders3.Append(bottomBorder3);
                Shading shading4 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9E2F3", ThemeFill = ThemeColorValues.Accent1, ThemeFillTint = "33" };
                TableCellVerticalAlignment tableCellVerticalAlignment3 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

                tableCellProperties3.Append(tableCellWidth3);
                tableCellProperties3.Append(tableCellBorders3);
                tableCellProperties3.Append(shading4);
                tableCellProperties3.Append(tableCellVerticalAlignment3);

                Paragraph paragraph3 = new Paragraph();

                ParagraphProperties paragraphProperties3 = new ParagraphProperties();
                ParagraphStyleId paragraphStyleId3 = new ParagraphStyleId() { Val = "14" };

                ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
                RunFonts runFonts3 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                FontSize fontSize3 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "20" };

                paragraphMarkRunProperties3.Append(runFonts3);
                paragraphMarkRunProperties3.Append(fontSize3);
                paragraphMarkRunProperties3.Append(fontSizeComplexScript3);

                paragraphProperties3.Append(paragraphStyleId3);
                paragraphProperties3.Append(paragraphMarkRunProperties3);

                if (comp.Count == 2)
                {
                    paragraph3.Append(paragraphProperties3, new Run(new Text(comp[1]?.Competence?.Name)));
                }
                else
                {
                    paragraph3.Append(paragraphProperties3, new Run(new Text(string.Empty)));
                }
                //OutOf Range

                tableCell3.Append(tableCellProperties3);
                tableCell3.Append(paragraph3);
                #endregion
                #region Cell4

                TableCell tableCell4 = new TableCell();

                TableCellProperties tableCellProperties4 = new TableCellProperties();
                TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "1120", Type = TableWidthUnitValues.Dxa };

                TableCellBorders tableCellBorders4 = new TableCellBorders();
                TopBorder topBorder4 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                LeftBorder leftBorder4 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                BottomBorder bottomBorder4 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };
                RightBorder rightBorder1 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)8U, Space = (UInt32Value)0U };

                tableCellBorders4.Append(topBorder4);
                tableCellBorders4.Append(leftBorder4);
                tableCellBorders4.Append(bottomBorder4);
                tableCellBorders4.Append(rightBorder1);
                Shading shading5 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9E2F3", ThemeFill = ThemeColorValues.Accent1, ThemeFillTint = "33" };
                TableCellVerticalAlignment tableCellVerticalAlignment4 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

                tableCellProperties4.Append(tableCellWidth4);
                tableCellProperties4.Append(tableCellBorders4);
                tableCellProperties4.Append(shading5);
                tableCellProperties4.Append(tableCellVerticalAlignment4);

                Paragraph paragraph4 = new Paragraph();

                ParagraphProperties paragraphProperties4 = new ParagraphProperties();
                ParagraphStyleId paragraphStyleId4 = new ParagraphStyleId() { Val = "14" };

                ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
                RunFonts runFonts4 = new RunFonts() { Ascii = "Arial", HighAnsi = "Arial", ComplexScript = "Arial" };
                FontSize fontSize4 = new FontSize() { Val = "20" };
                FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "20" };
                int limit = 0;
                //ADD THE STAR HERE
                if (comp.Count == 2)
                {
                    limit = comp[1].Rating;
                }
                else
                {
                    limit = 0;
                }
                OpenXmlElement[] Stars4 = Enumerable.Range(0, limit).Select(x => symbolChar.CloneNode(true)).ToArray();
                RunProperties FristStarRunProperties4 = new RunProperties();
                FristStarRunProperties4.RunFonts = new RunFonts { Ascii = "Arial", HighAnsi = "Arial" };
                FristStarRunProperties4.FontSize = new FontSize { Val = "20" };
                Run StarRun4 = new Run(FristStarRunProperties4);
                StarRun4.Append(Stars4);
                //
                paragraphMarkRunProperties4.Append(runFonts4);
                paragraphMarkRunProperties4.Append(fontSize4);
                paragraphMarkRunProperties4.Append(fontSizeComplexScript4);

                paragraphProperties4.Append(paragraphStyleId4);
                paragraphProperties4.Append(paragraphMarkRunProperties4);

                paragraph4.Append(paragraphProperties4, StarRun4);

                tableCell4.Append(tableCellProperties4);
                tableCell4.Append(paragraph4);
                #endregion
                tableRow1.Append(tableCell1);
                tableRow1.Append(tableCell2);
                tableRow1.Append(tableCell3);
                tableRow1.Append(tableCell4);
                table1.Append(tableRow1);

                tableRow1.Append(tablePropertyExceptions1);
                tableRow1.Append(tableRowProperties1);

            }

            table1.Append(tableGrid1);

            return table1;


        }

    }
}
