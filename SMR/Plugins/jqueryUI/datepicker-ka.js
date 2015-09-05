
(function (factory) {
    if (typeof define === "function" && define.amd) {
        // AMD. Register as an anonymous module.
        define(["../jquery.ui.datepicker"], factory);
    } else {

        // Browser globals
        factory(jQuery.datepicker);
    }
}(function (datepicker) {
    datepicker.regional['ka'] = {
        closeText: 'დახურვა',
        prevText: 'წინა',
        nextText: 'შემდეგი',
        currentText: 'დღეს',
        monthNames: ['იანვარი', 'თებერვალი', 'მარტი', 'აპრილი', 'მაისი', 'ივნისი',
			'ივლისი', 'აგვისტო', 'სექტემბერი', 'ოქტომბერი', 'ნოემბერი', 'დეკემბერი'],
        monthNamesShort: ['იან.', 'თებ.', 'მარ', 'აპრ', 'მაისი', 'ივნ',
			'ივლ.', 'აგვ', 'სექტ.', 'ოქტ.', 'ნოე.', 'დეკ.'],
        dayNames: ['კვირა', 'ორშაბათი', 'სამშაბათი', 'ოთხშაბათი', 'ხუთშაბათი', 'პარასკევი', 'შაბათი'],
        dayNamesShort: ['კვ.', 'ორშ.', 'სამშ.', 'ოთშ.', 'ხუთშ.', 'პარ.', 'შაბ.'],
        dayNamesMin: ['კ', 'ო', 'ს', 'ო', 'ხ', 'პ', 'შ'],
        weekHeader: 'კვირა.',
        dateFormat: 'dd/mm/yy',
        firstDay: 1,
        isRTL: false,
        showMonthAfterYear: false,
        yearSuffix: ''
    };
    datepicker.setDefaults(datepicker.regional['ka']);

    return datepicker.regional['ka'];

}));