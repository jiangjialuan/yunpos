




$.DHB._ = function () {
    app.c.public_data['xs/detail'] = app.c.public_data['xs/detail'] || {};
    if (app.c.public_data['xs/detail']['once'] === false) {
        app.c.public_data['xs/detail']['once'] = true;
        $.DHB.checkForm(function () {
            return false;
        });
        $(function () {
            $(_ + '#submit-button').removeAttr('disabled');
        });
    }
};


app.xs = app.xs || {};
app.xs.detail = app.xs.detail || {};


//编辑销售订单
app.xs.detail.edit = function (id, obj) {
    $.fn.menuTab.load({ url: '/xs/add?type=edit&id=' + id, 'title': '编辑销售订单', id: 'xs/add', nocache: '1' });
};

//新增销售订单
app.xs.detail.add = function (obj) {
    $.fn.menuTab.load({ url: '/xs/add', 'title': '新增销售订单', id: 'xs/add', nocache: '1' });
};

//复制
app.xs.detail.copy = function (id, obj) {
    $.fn.menuTab.load({ url: '/xs/add?type=copy&id=' + id, 'title': '复制销售订单', id: 'xs/add', nocache: '1' });
};


//销售出库
app.xs.detail.xsck = function (id, obj) {
    var options = {
        data: {
            id: id
        },
        url: $.DHB.U('xs/AllowCK'),
        type: "POST",
        datatype: 'json',
        beforeSend: function () { },
        success: function (data, textStatus, jqXHR) {
            if (data.status == "success") {
                $.fn.menuTab.load({ url: '/xsck/add?id_dd=' + id, 'title': '新增销售出库', id: 'xsck/add', nocache: '1' });
            }
            else {
                $.DHB.message({ 'content': data.message, 'type': 'i' });
            }
        },
        complete: function (XHR, TS) { }
    };
    app.httpAjax.post(options);

};

//审核
app.xs.detail.sh = function (id, obj) {
    $.messager.confirm("提示", "确定审核吗?", function () {

        var options = {
            data: {
                id: id
            },
            url: $.DHB.U('xs/sh'),
            type: "POST",
            datatype: 'json',
            beforeSend: function () { },
            success: function (data, textStatus, jqXHR) {
                if (data.status == "success") {
                    $.DHB.message({ 'content': data.message, 'time': 1000, 'type': 's' });
                    $.DHB.url('xs/detail?id=' + id, 'cache');
                }
                else {
                    $.DHB.message({ 'content': data.message, 'time': 0, 'type': 'e' });
                }
            },
            complete: function (XHR, TS) { }
        };
        app.httpAjax.post(options);

    });
};

//导出
app.xs.detail.importout_d = function () {
    debugger;
    app.xs.setresult(false);

    if ($(_ + "#shopsp_table_detail>tbody>tr[data-item!='']").length <= 0) {
        $.DHB.message({ 'content': '无有效的数据！', 'type': 'i' });
    }
    else {

        var shopspList = $(_ + 'input[name="table_result"]').val();
        window.location.href = $.DHB.U('/xs/importout?shopspList=' + shopspList);
    }

}


//改动后重新计算和赋值
app.xs.setresult = function (ifRemove) {
    var e = [];
    var shopsp = [];
    var totleMoney = 0;
    var xh = 1;
    debugger;

    $(_ + '#shopsp_table_detail>tbody').find('tr').each(function () {
        debugger;

        $(this).find('div[name="xh"]').text(xh);
        var shopsp_e = {};
        var shopsp_obj = $(this).find('input[name="shopsp_obj"]');
        shopsp_e.id_shopsp = shopsp_obj.val();
        shopsp_e.id_kcsp = $.trim(shopsp_obj.attr("data-id_kcsp"));//仓库id
        shopsp_e.id_sp = $.trim(shopsp_obj.attr("data-id_sp"));//id_sp
        shopsp_e.sl = $.trim($(this).find('input[name="sl"]').val()); //数量
        shopsp_e.dj = $.trim($(this).find('input[name="dj_jh"]').val()); //单价
        shopsp_e.barcode = $.trim($(this).find('input[name="barcode"]').val());//条码
        shopsp_e.dw = $(this).find('div[name=dw_select]>div>span').html();//单位
        shopsp_e.bz = $.trim($(this).find('input[name="bz"]').val());//备注
        shopsp_e.zhl = $.trim($(this).find('div[name=dw_select]>div>span').attr('data-zhl')); //转换率
        shopsp_e.shopsp_name = $(this).find('td[name="mc"] div span').text();;//商品名称
        shopsp_e.dj_ls = $(this).find('td[name="dj_ls"] div').text();
        shopsp_e.sl_kc = $(this).find('td[name="sl_kc"] div').text();

        //数量总数
        var sl_total = accMul(parseFloat(shopsp_e.zhl), parseFloat(shopsp_e.sl));                     //(parseFloat(shopsp_e.zhl) * parseFloat(shopsp_e.sl));
        sl_total = limit_num(sl_total.toString(), app.xs.sl_digit)
        $(this).find('input[name="sl_total"]').val(sl_total);
        shopsp_e.sl_total = $.trim(sl_total);

        shopsp_e.je = $.trim($(this).find('input[name="je"]').val()); //金额

        if (shopsp_e.id_shopsp != '') {
            shopsp.push(shopsp_e);
        }
        xh++;
    });

    var jsonStr = JSON.stringify(shopsp);
    $(_ +" #table_result").val(jsonStr);

}
