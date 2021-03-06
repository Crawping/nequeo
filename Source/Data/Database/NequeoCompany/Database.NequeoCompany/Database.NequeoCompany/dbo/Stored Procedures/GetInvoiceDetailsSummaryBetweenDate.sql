﻿CREATE PROCEDURE [dbo].[GetInvoiceDetailsSummaryBetweenDate]
	@FromDate datetime, @ToDate datetime
AS
	SELECT Totals = SUM(IDS.Total) + SUM(IDS.GST), PreGST = Round((SUM(IDS.Total) + SUM(IDS.GST)) - ((SUM(IDS.Total) + SUM(IDS.GST)) / [dbo].[GetGSTMultiplierValue]()), 2)
	FROM Invoices I, InvoiceDetails IDS
	WHERE   (  ((I.InvoiceDate >= @FromDate) AND (I.InvoiceDate <= @ToDate))
		AND  ( I.InvoiceID = IDS.InvoiceID) )
RETURN