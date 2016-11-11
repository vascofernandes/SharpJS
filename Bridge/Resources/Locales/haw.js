﻿Bridge.merge(new System.Globalization.CultureInfo("haw", true), {
    englishName: "Hawaiian",
    nativeName: "Hawaiʻi",

    numberFormat: Bridge.merge(new System.Globalization.NumberFormatInfo(), {
        naNSymbol: "NaN",
        negativeSign: "-",
        positiveSign: "+",
        negativeInfinitySymbol: "-Infinity",
        positiveInfinitySymbol: "Infinity",
        percentSymbol: "%",
        percentGroupSizes: [3],
        percentDecimalDigits: 2,
        percentDecimalSeparator: ".",
        percentGroupSeparator: ",",
        percentPositivePattern: 0,
        percentNegativePattern: 0,
        currencySymbol: "$",
        currencyGroupSizes: [3],
        currencyDecimalDigits: 2,
        currencyDecimalSeparator: ".",
        currencyGroupSeparator: ",",
        currencyNegativePattern: 0,
        currencyPositivePattern: 0,
        numberGroupSizes: [3],
        numberDecimalDigits: 2,
        numberDecimalSeparator: ".",
        numberGroupSeparator: ",",
        numberNegativePattern: 1
    }),

    dateTimeFormat: Bridge.merge(new System.Globalization.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["Lp","P1","P2","P3","P4","P5","P6"],
        abbreviatedMonthGenitiveNames: ["Ian","Pep","Mal","ʻAp","Mei","Iun","Iul","ʻAuk","Kep","ʻOk","Now","Kek",""],
        abbreviatedMonthNames: ["Ian","Pep","Mal","ʻAp","Mei","Iun","Iul","ʻAuk","Kep","ʻOk","Now","Kek",""],
        amDesignator: "AM",
        dateSeparator: "/",
        dayNames: ["Lāpule","Pōʻakahi","Poʻalua","Poʻakolu","Poʻahā","Poʻalima","Poʻaono"],
        firstDayOfWeek: 0,
        fullDateTimePattern: "dddd, MMMM dd, yyyy h:mm:ss tt",
        longDatePattern: "dddd, MMMM dd, yyyy",
        longTimePattern: "h:mm:ss tt",
        monthDayPattern: "d MMMM",
        monthGenitiveNames: ["Ianuali","Pepeluali","Malaki","ʻApelila","Mei","Iune","Iulai","ʻAukake","Kepakemapa","ʻOkakopa","Nowemapa","Kekemapa",""],
        monthNames: ["Ianuali","Pepeluali","Malaki","ʻApelila","Mei","Iune","Iulai","ʻAukake","Kepakemapa","ʻOkakopa","Nowemapa","Kekemapa",""],
        pmDesignator: "PM",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "M/d/yyyy",
        shortestDayNames: ["Lp","P1","P2","P3","P4","P5","P6"],
        shortTimePattern: "h:mm tt",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        sortableDateTimePattern1: "yyyy'-'MM'-'dd",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "MMMM, yyyy",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.uzzz"
    })
});