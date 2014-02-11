function InitializeFrameSize() {
	var nav_left = $('.nav-left');
	var nav_left_handle = $('.nav-left-handle');
	var sub_content = $('.sub-content');
	var content = sub_content.parent();
	var nav_top = $('.nav-top');
	var view_path = $('.view-path');
	var header = $('.header');
	var footer = $('.footer');
	var is_nav_left_handler_clicked = true;
	var nav_left_max_width = Number(nav_left.attr('maxWidth'));
	var nav_left_width = nav_left_max_width;
	var nav_top_height = nav_top.length == 0 ? 0 : nav_top.height();

	$(window).resize(function () {
		setTimeout(resize_content_area, 1);
	});

	resize_content_area();

	setTimeout(function () { $('body').css('zoom', 1); }, 1);

	function resize_content_area() {
		var h = $('body').get(0).clientHeight - header.height() - view_path.outerHeight() - footer.height() - (content.outerHeight() - content.height());
		content.height(h);
		resize_nav_left();
		resize_subcontent_area();
		content.css('visibility', 'visible');
	}

	function resize_subcontent_area() {
		if (nav_left.length == 0) {
			sub_content.css({ width: content.get(0).clientWidth - 30 });
			return true;
		}

		sub_content.css({
			width: content.get(0).clientWidth - nav_left.get(0).clientWidth - nav_left_handle.width() - 30,
			marginLeft: nav_left.width() + nav_left_handle.width()
		});

	}

	function resize_nav_left() {
		if (nav_left.length == 0) { return true; }
		if (is_nav_left_handler_clicked) {
			is_nav_left_handler_clicked = false;
			var is_collapse = nav_left.attr('collapse') == 'true';
			nav_left.attr('collapse', !is_collapse);
			nav_left_width = is_collapse === true ? nav_left_max_width : 0;
			nav_left_handle.toggleClass('nav-left-handle-collapse');
		}

		nav_left.css({
			height: content.get(0).clientHeight,
			overflow: nav_left_width === 0 ? 'hidden' : '',
			width: nav_left_width
		});

		nav_left_handle.css({
			height: content.get(0).clientHeight,
			left: nav_left_width
		});

		if (typeof (navLeftResizeComplete) == 'function') {
			navLeftResizeComplete();
		}
	}

	nav_left_handle.click(function () {
		is_nav_left_handler_clicked = true;
		resize_nav_left();
		resize_subcontent_area();
	});
}

//导航条下拉菜单
function select_list() {
	$(".nav-anchor").click(function () {
		$("#dropdown_list").show();
	}).mouseleave(function () {
		$("#dropdown_list").hide();
	});
}


//顶部导航条：高亮当前功能
function HighlightNavTopItem(fid) {
	$('.nav-top [fid]').each(function (i, li) {
		if ($(li).attr('fid') == fid) {
			$(li).addClass('current');
		}
	});
}
//生成当前页面的面包屑
function GenerateFunctionPath(fid, tree) {

	var pathArray = [];
	var currentPage = $(tree).find('#' + fid);
	var allNodes = currentPage.parents('li').find('>a');
	//	if (allNodes.length == 1) {
	//		$('.view-path').remove();
	//		return true;
	//	}

	if (currentPage.length == 0) {
		//		if (location.hostname === 'localhost') { alert('Current Page is not registered'); }
		//		location.href = '/';
		return;
	}

	var functionNameArray = [];

	allNodes.each(function (i, a) {
		var url = $(a).attr('href');
		if (url == undefined) {
			url = '#';
		}
		if (!$(a).text()) { return false; }
		if ($(a).attr('self') !== undefined) {
			pathArray.push(generatePathLink($(a).text(), $.query.set('preventCache', new Date().getTime()).toString()));
		} else if ($(a).attr('parent') !== undefined) {
			pathArray.push(generatePathLink($(a).text(), url + $.query.toString()));
		} else if ($(a).attr('returnUrl') !== undefined) {
			var currentReturnUrl = $.query.get('returnUrl');
			if (currentReturnUrl === true || currentReturnUrl == '') {
				currentReturnUrl = location.href;
			}
			pathArray.push(generatePathLink($(a).text(), currentReturnUrl));
		} else if ($(a).attr('dynamic') !== undefined) {
			var dynamicMark = $('a[dynamic]');
			if (dynamicMark.length == 0) {
				pathArray.push(generatePathLink('Contract Name', '#'));
			} else {
				pathArray.push(generatePathLink(dynamicMark.text(), dynamicMark.attr('href')));
			}
		} else {
			pathArray.push(generatePathLink($(a).text(), url));
		}
	});

	function generatePathLink(name, url) {
		functionNameArray.push(name);
		return String.format('<li><a href="{0}">{1}</a></li>', url, name);
	}

	function addBackButton() {
		if (pathArray.length < 2) {
			return;
		}

		var validPathArray = $(pathArray)
		var currentLevel = $(pathArray[0]);
		var previousLevel = $(pathArray[1]);
		if (previousLevel.find('a').attr('href') == '#') {
			previousLevel = $(pathArray[2]);
		}
		if (pathArray[0].indexOf('首页') == -1) {
			var previousLink = previousLevel.find('a');
			var currentLink = currentLevel.find('a');
			var url = $.query.get('returnUrl') || previousLink.attr('href');
			var text = currentLink.text();
			var pnlBack = String.format('<a class="inline-block" href="{0}" title="返回【{2}】"></a><h1 class="inline-block">{1}</h1>', url, text, previousLink.text());

			$('.sub-content #pnlBackToPreviousPage').hide().html(pnlBack).fadeIn(1000);
		}
	}

	addBackButton();

	//	$('.view-path').html(pathArray.reverse().join('<b>></b>'));

	//Set Title
	var currentPageTitle = currentPage.attr('title');
	document.title = currentPageTitle == undefined ? String.format('共青团塘沽委员会协同工作OA系统 - {0}', functionNameArray.reverse().join(' - ')) : currentPageTitle;
}

function GenerateMainFunctionMenu(fid, tree) {
	function hideAllSecondView() {
		$('div.nav-top .second-view').hide();
	}

	var functionNameArray = [];
	var currentPage = $(tree).find('#' + fid);
	if (currentPage.length == 0) {
		//		alert('Current Page is not registered');
		return;
	}
	var currentFirstLevelSelector = String.format('[level="1"]:has("#{0}")>li>a', fid);

	var currentMainFunctionName = $(tree).find(currentFirstLevelSelector).text();

	var allFirstLevelSelector = String.format('[level="1"]>li>a');

	functionNameArray.push('<ul class="main-view">');

	$(tree).find(allFirstLevelSelector).each(function (i, a) {

		var secondLevelFunctionMenu = GetSecondLevelFunctionMenu(fid, tree, $(a).attr('id'));
		var url = $(a).next().find('a:not(.disabled)').first().attr('href');
		if ($(a).attr('id') == fid || $(a).parent().find('#' + fid).length > 0) {
			functionNameArray.push(generateMainFunctionLink($(a).text(), url, secondLevelFunctionMenu, true));
		}
		else {
			functionNameArray.push(generateMainFunctionLink($(a).text(), url, secondLevelFunctionMenu, false, $(a).hasClass('disabled')));
		}

	});

	functionNameArray.push('</ul>');

	function generateMainFunctionLink(name, url, nextLevelMenu, isSelected, isDisabled) {
		var className = [];
		if (isSelected) {
			className.push('nav-top-selected');
		}
		if (isDisabled) {
			className.push('disabled');
		}
		return String.format('<li><a href="{0}" class="{3}">{1}</a>{2}</li>', url, name, '', className.join(' '));
	}

	$('.nav-top').html(functionNameArray.join('')).find('.disabled').removeAttr('href');
}


function GetSecondLevelFunctionMenu(fid, tree, firstLevelFID) {

	var childFunctionArray = [];
	var currentFirstLevel = $(tree).find('#' + firstLevelFID).first();

	childFunctionArray.push('<ul class="second-view">');

	var secondLevelSelector = 'ul[level="2"]>li:not(.hidden)>a';
	var allSecondLevelLinks = currentFirstLevel.parent().parent().find(secondLevelSelector);

	var currentSecondLevel = currentFirstLevel.parent().parent().find(String.format('ul[level="2"]>li:has(#{0})>a', fid));

	if (allSecondLevelLinks.length == 0) { return ''; }
	allSecondLevelLinks.each(function (i, a) {
		if ($(a).attr('id') == currentSecondLevel.attr('id')) {
			childFunctionArray.push(generateChildFunctionLink($(a).text(), $(a).attr('href'), true));
		}
		else {
			childFunctionArray.push(generateChildFunctionLink($(a).text(), $(a).attr('href')));
		}
	});

	childFunctionArray.push('</ul>');

	return childFunctionArray.join('');


	function generateChildFunctionLink(name, url, isSelected) {
		return String.format('<li{2}><a href="{0}">{1}</a></li>', url, name, isSelected === true ? ' class="nav-selected"' : '');
	}
}

function GenerateNavLeftFunctionMenu(fid, tree) {

	var childFunctionArray = [];
	var currentPage = $(tree).find('#' + fid);
	if (currentPage.length == 0 || currentPage.parent().hasClass('hidden')) {
		return;
	}

	childFunctionArray.push('<ul class="nav-left-menu">');

	var currentSecondLevelSelector = String.format('ul[level="2"]:has("#{0}")', fid);
	var currentSecondLevel = $(tree).find(currentSecondLevelSelector);
	currentSecondLevel.find('[thirdLevel] > ul').hide();
	collapseThirdLevel();

	function collapseThirdLevel() {
		var collapseThirdLevelSelector = String.format('> li > ul:not(:has("#{0}"))', fid);
		currentSecondLevel.find(collapseThirdLevelSelector).hide();
	}

	$('.nav-left').prepend(currentSecondLevel);
	var navSelected = $(String.format('[id={0}]:last', fid));
	var thirdLevel = navSelected.parents('[thirdLevel]');
	if (thirdLevel.length > 0) {
		thirdLevel.find('>a').addClass('nav-selected').prepend('<b></b>');
	} else {
		navSelected.addClass('nav-selected').prepend('<b></b>');
	}

	$('.nav-left a.disabled').removeAttr('href').css('opacity', 0.3);

	$('.nav-left').find('a:not([href]):not(.disabled)').click(function () {
		$(this).next().toggle();
	});
}

function FindMarkAndGenerateNavigateElements() {
	var markName = 'viewIndex';
	var mark = $(String.format('[{0}]', markName)).last();
	if (mark.length == 0) {
		return false;
	}
	var fid = mark.attr(markName);
	$.noCacheGet(UrlResource.ViewIndex, {}, function (tree) {
		tree = String.format('<div>{0}</div>', tree);
		CheckPermission(fid, tree);
		GenerateMainFunctionMenu(fid, tree);
		GenerateFunctionPath(fid, tree);
		SetMinHeightForContentArea();
		GenerateHomePageIcon(fid, tree);
		GenerateHomeIconShortcutPanel(fid, tree);
	});
}

$.extend({
	noCacheGet: function (url, data, callback, type) {
		if (jQuery.isFunction(data)) {
			type = type || callback;
			callback = data;
			data = undefined;
		}

		return jQuery.ajax({
			type: "GET",
			url: url,
			data: data,
			cache: false,
			success: callback,
			dataType: type,
			contentType: "application/x-www-form-urlencoded; charset=utf-8"
		});
	}
});

function BindAllDisabledButton() {
	$('.disabled-button').click(function () {
		alert(this.title);
	});
}

function BindNonNumberBlocker(selector, allowNegative, allowZero) {
	if (allowNegative == undefined) { allowNegative = true; }
	if (allowZero == undefined) { allowZero = false; }
	$(selector).keydown(function (e) {
		// 9: Tab; 8 : Backspace; 16: Shift; 46: Delete; 33~40: Left, Right, Up, Down, Home, End, PageUp, PageDown; 96~105: NumPad(0-9); 48~57: 0-9
		if (e.keyCode == 8 || e.keyCode == 9 || e.keyCode == 16 || e.keyCode == 46
		|| (e.keyCode >= 33 && e.keyCode <= 40)
		|| (e.keyCode > 96 && e.keyCode <= 105)
		|| (e.keyCode > 48 && e.keyCode <= 57 && e.shiftKey == false)
		//|| (allowNegative && $(this).val() == '' && (e.keyCode == 189 || e.keyCode == 109))
		|| (allowZero && e.keyCode == 48 && e.shiftKey == false && $(this).val() == '')
		|| (e.keyCode == 48 && e.shiftKey == false && $(this).val() != '') // not blank, always allow zero
		|| (e.keyCode == 96 && e.shiftKey == false && $(this).val() != '')
		) { } else { e.preventDefault(); }
	});
}

function BindDatePickerTriggerEvent() {
	$('.ui-datepicker-trigger, .hasDatepicker').click(AppendClearButtonToDatePicker);
	function AppendClearButtonToDatePicker() {
		var picker = $('#ui-datepicker-div');
		var panel = picker.find('.ui-datepicker-buttonpane');
		var btnClearDate = panel.find('#clearDateField');

		if (btnClearDate.length > 0) { return false; }

		btnClearDate = $('<button type="button" id="clearDateField" class="ui-datepicker-close ui-state-default ui-priority-primary ui-corner-all">清空</button>');
		panel.append(btnClearDate);

		btnClearDate.click(function () {
			var inputID = /'(#.+?)'/.exec(picker.find('select:first').attr('onchange'))[1];
			$(inputID).val('');
		});
	}
}

function DatePickerZIndexPatch() {
	$('.ui-datepicker-trigger').click(function () {
		$('#ui-datepicker-div').css('z-index', 2);
	});
}

function ApplyStyleToCommonTable() {
	if ($.browser.msie) {
		$('table.table-common > tbody > tr:even').addClass('even');
	}
}

function LimitTextBoxMaxLength() {
	var allTextBoxes = $('input[type="text"]:not([maxlength])');
	allTextBoxes.attr('maxlength', 45);
	var allTextArea = $('textarea:not([maxlength])');
	allTextArea.attr('maxlength', 200);
}

$(document).ready(function () {
	ApplyStyleToCommonTable();
	//	LimitTextBoxMaxLength();
	hideDeleteButton();
	BindKeyDownEventToSearchBox();
	InitializeListFilter();
	DisableSubmitButtonAfterClicked();
	AddHintForEllipsisContent();
	CheckBrowserVersion();
	GodMode();
});

//全选功能
function BindTableCheckBoxEvent(containerSelector, fn) {

	var container = containerSelector ? $(containerSelector) : $('body');
	if (container.length == 0) { return; }
	var btnCheckAll = container.find('th:first-child :checkbox');
	btnCheckAll.prop('isAffectHiddenRows', true);
	var enabledCheckboxesSelector = 'td:first-child :checkbox:not(:disabled)';

	btnCheckAll.change(function () {
		var enabledCheckboxes = container.find(enabledCheckboxesSelector);
		if (btnCheckAll.prop('isAffectHiddenRows') === false) {
			enabledCheckboxes = enabledCheckboxes.filter(':visible');
		}
		enabledCheckboxes.prop('checked', this.checked);
		fn && fn(this.checked);
	})

	container.find(enabledCheckboxesSelector).change(changeCheckAllButtonState);

	function changeCheckAllButtonState() {

		var enabledCheckboxes = container.find(enabledCheckboxesSelector);
		if (btnCheckAll.prop('isAffectHiddenRows') === false) {
			enabledCheckboxes = enabledCheckboxes.filter(':visible');
		}
		var checkedBoxCount = enabledCheckboxes.filter(':checked').length;
		btnCheckAll.prop('checked', enabledCheckboxes.length != 0 && checkedBoxCount == enabledCheckboxes.length);
		fn && fn(checkedBoxCount > 0);
	}

	window.UpdateCheckAllButtonState = changeCheckAllButtonState;

	changeCheckAllButtonState();

	btnCheckAll.prop('isAffectHiddenRows', false);
	if (btnCheckAll.filter(':disabled').length > 0) {
		btnCheckAll.hide();
	}
}

function hideDeleteButton() {
	var table = $('table');
	if (table.length != 0) {
		var btn = $('input[type=button]').filter('[value="删除"]');
		if (table.find('tr td :checkbox').length > 0) {
			if (table.find('tr td :checkbox:enabled').length === 0) {
				btn.val() == "删除" ? btn.show().remove() : "";
			}
		} else {
			btn.hide();
		}

	}
}

function BindKeyDownEventToSearchBox() {
	var btnSearch = $(':submit[value="搜索"]');
	if (btnSearch.length > 0) {
		btnSearch.parent().find(':text').keydown(startSearch);
	}

	function startSearch(e) {
		if (e.keyCode == 13) {
			btnSearch.click();
		}
	}

}

function InitializeListFilter(custom) {
	var pnlFilter = $('.list-filter');
	if (pnlFilter.length == 0) return;
	var allKeys = custom ? custom : $.query.keys;

	for (var key in allKeys) {
		if (key.toLowerCase() == 'pageindex') { continue; }
		var nodes = key.split('.');
		var lastNode = nodes[nodes.length - 1];
		var input = pnlFilter.find(String.format('[name="{0}"]', lastNode));

		var value = allKeys[key];
		if (value === true || value === '') {
			// ignore
		} else {
			if (input.length > 0) {
				//change
				input.val(value);
			} else {
				//append
				pnlFilter.prepend(String.format('<input type="hidden" name="{0}" value="{1}"/>', key, allKeys[key]));
			}
		}

	}

	pnlFilter.find('select').change(function () {
		pnlFilter.submit();
	});

	pnlFilter.find(':submit:[value="搜索"]').click(function () {
		pnlFilter.find(':input').each(function () {
			if (this.value.length == 0) {
				$(this).removeAttr('name');
			}
		});
	});
}

function DisableObject(obj, isDisabled) {
	var strDisabled = 'disabled';
	if (isDisabled === false) {
		$(obj).removeAttr(strDisabled);
		$(obj).parent().prev().find('em').show();
	} else {
		$(obj).attr(strDisabled, strDisabled).removeClass('input-validation-error').nextAll('span').empty();
		$(obj).parent().prev().find('em').hide();
	}
	selectBlankOption(obj, isDisabled);

	function selectBlankOption(obj, isDisabled) {
		if ($(obj).get(0).tagName == 'SELECT') {
			if (isDisabled === false) {
				$(obj).find(':selected:empty').remove();
			} else {
				$(obj).append('<option selected />');
			}
		} else {
			$(obj).val('');
		}
	}
}

function HideFormRow(obj, isHide) {
	if (isHide == undefined) {
		isHide = true;
	}
	var row = $(obj).parents('dd').prev().andSelf();
	row.toggle(!isHide);
}

function GetQueryObjects() {
	var params = $.query.get();
	for (var item in params) {
		if (params[item] === true) {
			params[item] = '';
		}
	}
	return params;
}

function DisableSubmitButtonAfterClicked() {
	return;
	$(document).on('click', 'input:submit', function () {
		var btnSubmit = $(this);
		var frm = btnSubmit.parents('form');
		if (frm.valid !== undefined && frm.valid() === false) { return; }
		btnSubmit.hide()
		setTimeout(function () {
			btnSubmit.show();
		}, 2000);
	});
}

function AddHintForEllipsisContent() {
	$('.ellipsis-content').each(function (i, content) {
		$(this).attr('title', $(this).text().trim());
	});
}

function RefreshPage(closeDialog) {
	var tableSelector = 'div.sub-content > table.table-common > tbody';
	var table = $(tableSelector);
	if (table.length > 0) {
		if (window.Refreshing === true) { return; }
		Refreshing = true;
		if (closeDialog !== false) {
			var currentDialog = $('div.ui-dialog-content:visible');
			currentDialog.length > 0 && currentDialog.dialog('close');
		}
		$.get(location.href, function (data) {
			table.replaceWith($(data).find(tableSelector));

			var pagerSelector = 'div.sub-content > div > .mvcPager';
			if ($(pagerSelector).length > 0) {
				$(pagerSelector).replaceWith($(data).find(pagerSelector));
			}
			Refreshing = false;
		});
	} else {
		location.reload();
	}
}

function GenerateHomePageIcon(fid, tree) {

	var pnlIcons = $('#pnlIcons');

	if (pnlIcons.length == 0) {
		return;
	}

	var childFunctionArray = [];
	var currentPage = $(tree).find('#' + fid);
	if (currentPage.length == 0 || currentPage.parent().hasClass('hidden')) {
		return;
	}

	var currentSecondLevelSelector = String.format('ul[level="2"]:has("#{0}")', fid);
	var currentSecondLevel = $(tree).find(currentSecondLevelSelector);
	var icons = currentSecondLevel.find('[class]');



	icons.filter('.disabled').removeAttr('href').addClass('no-permission').attr('title', '无权访问');

	icons.each(function (i, icon) {
		var text = $(icon).text();
		var classes = icon.className.split(' ');

		if (classes.length == 1 && (classes[0] == 'disabled' || classes[0] == '')) {
			$(icon).removeAttr('class');
		} else {
			$(icon).text('').append(String.format('<span>{0}</span>', text)).addClass('home').append('<b />'); ;
		}

	});


	pnlIcons.append(icons.filter('[class]'));
	$('#pnlContainer').css('visibility', 'visible');
}


function ToggleFrameSize() {


	var sub_content = $('.sub-content');
	var content = sub_content.parent();
	var nav_top = $('.nav-top');
	var view_path = $('.view-path');
	var header = $('.header');
	var footer = $('.footer');

	//	footer.hide();

	var body = $('body');
	var bodyAndHtml = $('html,body');

	$(window).resize(function () {
		setTimeout(toggleMode, 50);
	});

	$(window).resize();
	setTimeout(function () { $('body').css('zoom', 1); }, 1);

	function toggleMode() {
		var h = body.get(0).clientHeight - header.height() - footer.height() - (content.outerHeight() - content.height());
		if (h < sub_content.height()) {
			bodyAndHtml.addClass('auto')
		} else {
			bodyAndHtml.removeClass('auto');
		}
	}
}

function CheckPermission(fid, tree) {

	var currentPage = $(tree).find('#' + fid).last();

	if (currentPage.length == 0) {
		alert('您没有权限访问此页');
		return;
	}

}

function FireDatePickerChangeEvent() {
	$(this).blur();

}

function initializeEditor(pnlEditor) {
	if (pnlEditor.length == 0) { return; }
	pnlEditor.find(':input').each(function (i, input) {
		$(input).attr('hash', getValue(input).hashCode());
	});
	function getValue(input) {
		var value = $(input).prop('type') == 'checkbox' ? $(input).prop('checked') : $(input).val();
		return String(value);
	}
}

function checkEditor(pnlEditor) {
	window.LeavingPrompt = false;
	pnlEditor.find(':input').each(function (i, input) {
		if (getValue(input).hashCode().toString() != $(input).attr('hash')) {
			window.LeavingPrompt = true;
			return false;
		}
	});
	function getValue(input) {
		var value = ($(input).prop('type') == 'checkbox' || $(input).prop('type') == 'radio') ? $(input).prop('checked') : $(input).val();
		return String(value);
	}
}

function HighlightKeyword(containerSelector) {

	var container = containerSelector ? $(containerSelector) : $('body');
	var keyword = container.find('.keyword-searcher [name="searchKey"]').val().trim();

	var tblResult = container.find('.table-common');


	tblResult.find('span[origin]').each(function (i, span) {
		$(span).replaceWith($(span).attr('origin'));
	});

	if (keyword.length == 0) {
		return;
	}

	var exclusiveHeaderList = ['序号', '操作', '状态', '可选操作', '发送对象', '抄送对象', '类型', '大小', '微博地址', '距上次访问', '团员信息', '信息完善', '成员人数', '出生日期', '申请时间', '上报时间', '截止时间', '发布时间', '上传时间', '发送时间', '入团日期', '更新时间'];

	tblResult.find('th').each(function (i, th) {
		var title = $(th).text().trim();
		if (exclusiveHeaderList.indexOf(title) > -1 || title.length == 0) {
			return true;
		}
		highlightColumn(i + 1); // :nth-child is 1-indexed
	});


	function highlightColumn(index) {
		var keywordToSearch = keyword.escapeChar();
		tblResult.find(String.format('td:nth-child({0})', index)).each(function (i, td) {
			var contents = $(td).find('*').andSelf().contents();

			contents.each(function (i, node) {
				if (node.nodeName == '#text') {
					var exp = new RegExp('(' + keywordToSearch + ')', 'gim');
					if (!exp.test(node.nodeValue)) { return true; }
					var highlightedText = node.nodeValue.replace(exp, '<em key>$1</em>');

					setTimeout(function () {
						$(node).replaceWith(String.format('<span origin="{0}">{1}</span>', node.nodeValue, highlightedText));
					}, 50);
				}
			});


		});
	}
}



function SpecialCheckAll(target, fn) {
	var checkAll = target.find('thead :checkbox');
	var checkBox = target.find('tbody :checkbox');
	checkAll.unbind('change').unbind('click').click(function () {
		target.find('input:checkbox:visible').attr("checked", this.checked);
		if (fn) {
			fn(checkAll);
		}
	});
	checkBox.click(function () {
		checkAll.attr('checked', checkBox.length == checkBox.filter(':checked').length);
	});
}

function MakeReadOnlyUnselectable() {
	if ($.browser.msie) {
		$(':input[readonly]').attr('UNSELECTABLE', 'on');
	}
}

function HidePanelWhileClickingOutside(btnTarget, pnlTarget) {
	$(document).mousedown(function (e) {
		var isInsidePanel =
            btnTarget.is(e.srcElement)
            || pnlTarget.is(e.srcElement)
            || pnlTarget.has(e.srcElement).length == 1;

		if (!isInsidePanel) {
			pnlTarget.fadeOut();
		}
	});
}

window.CONST = {
	WINDOW: {
		NEWS: { WIDTH: 640, HEIGHT: 600 },
		LARGE: { WIDTH: 960, HEIGHT: 650 },
		NARROW: { WIDTH: 600, HEIGHT: 225 },
		NARROWER: { WIDTH: 600, HEIGHT: 180 },
		REFUSE: { WIDTH: 450, HEIGHT: 300 }
	}
}

function BindValidateTextboxSize(div) {
	if (!div) {
		div = 'body';
	}
	div = $(div);
	var allTextbox = div.find('[data-val-length-max], [data-val-regex]');

	allTextbox.each(function (i, textbox) {

		// add title for all textboxes
		var lengthLimitHint = $(this).attr('data-val-length') || $(this).attr('data-val-regex');
		var lengthLimit = parseInt($(textbox).attr('data-val-length-max'), 10);
		if (lengthLimitHint) {
			if (lengthLimit > 10000) {

			} else {
				if (!textbox.readOnly && !textbox.disabled) {
					$(textbox).attr('title', lengthLimitHint);
				}
			}
		}

		// dynamic generate validation error hint
		if (lengthLimit) {
			$(textbox).attr('maxlength', lengthLimit);
			var validator = $(textbox).parents('form').validate();
			var settings = validator.settings;
			var message = settings.messages[textbox.name];

			// Triple Line Textarea
			var rule = settings.rules[textbox.name];

			if (message) {
				if (lengthLimitHint.indexOf('每行') > -1) {
					rule.maxlength = function () {
						var errorMessage = [];
						var value = $(textbox).val();
						var lines = value.split('\n');
						for (var i = 0; i < lines.length; i++) {
							if (i >= maxLineCount) {
								return 1;
							}
							var overLength = lines[i].length - maxLengthPerLine;
							if (overLength > 0) {
								return 1;
							}
						}
						return lengthLimit;
					};
					var maxLineCount = 3;
					var maxLengthPerLine = 27;
					var originalMessage = message.maxlength;
					var originalRequiredMessage = message.required;
					message.required = function () {
						settings.errorClass = 'input-validation-error';
						return originalRequiredMessage;
					};
					message.maxlength = function () {
						var errorMessage = [];
						var value = $(textbox).val();
						var lines = value.split('\n');
						for (var i = 0; i < lines.length; i++) {
							if (i >= maxLineCount) {
								errorMessage.push(String.format('{0}. 标题不能超过{1}行', errorMessage.length + 1, maxLineCount));
								break;
							}
							var overLength = lines[i].length - maxLengthPerLine;
							if (overLength > 0) {
								errorMessage.push(String.format('{0}. 第{1}行已经超出{2}个字', errorMessage.length + 1, i + 1, overLength));
							}
						}

						if (errorMessage.length == 0) {
							if (value.length > 0) {
								settings.errorClass = 'valid';
								$(textbox).removeClass('input-validation-error');
								return '';
							} else {
								settings.errorClass = 'input-validation-error';
								return originalMessage;
							}

						}
						settings.errorClass = 'input-validation-error';
						return String.format('【{0}】: {1}', lengthLimitHint, errorMessage.join(', '));
					}
					return;
				};
				message.maxlength = function () {
					settings.errorClass = "valid";
					var maxLength = $(textbox).attr('data-val-length-max');
					var text = $(textbox).val();

					$(textbox).val(text.substr(0, maxLength));
					return '';
					//					return String.format('超过字数限制({0})，只保留前{0}位', maxLength);
					//										var lengthLimit = parseInt($(textbox).attr('data-val-length-max'), 10);
					//										return String.format('字数限制:{1}, 已超出{0}个字', $(textbox).val().length - lengthLimit, lengthLimit);
				}
			}
		}
	});
}

function GetImportResult(successfulTemplate, failedTemplate, refreshTemplate, data) {

	data = data.toJson();
	if (data.Code !== 0) {
		alert(data.Msg + refreshTemplate);
		return;
	}
	data = data.Data;
	if (data.UnSuccessfulCount == 0) {
		alert(String.format(successfulTemplate + refreshTemplate, data.SuccessfulCount));
	} else {
		ShowAlertMessage(String.format(successfulTemplate + failedTemplate + refreshTemplate, data.SuccessfulCount, data.UnSuccessfulCount, data.UnSuccessfulData.join('\n')));
	}
}

function CheckBrowserVersion() {
	var b = $.browser;

	if (b.msie && b.version > 6) { return; }

	if ((b.safari || b.webkit) && false == /iPad/i.test(navigator.userAgent)) { return; }

	var pnlBrowserNotification = $('#pnlBrowserNotification');
	pnlBrowserNotification.show();

	setTimeout(function () {
		pnlBrowserNotification.fadeOut();
	}, 5000);

}

function GodMode() {
	window.IsGod = location.hostname == 'localhost' && $.query && $.query.get('god') == '1';
}

function GenerateHomeIconShortcutPanel(fid, tree) {

	var pnlIcons = $('#pnlIcons');

	if (pnlIcons.length > 0) {
		return;
	}

	pnlIcons = $('<div id="pnlHomeIconsShortcut"></div>');

	var childFunctionArray = [];
	var currentPage = $(tree).find('#' + fid);
	if (currentPage.length == 0 || currentPage.parent().hasClass('hidden')) {
		return;
	}

	var currentSecondLevelSelector = String.format('ul[level="2"]:has("#{0}")', fid);
	var currentSecondLevel = $(tree).find(currentSecondLevelSelector);
	var currentNode = currentSecondLevel.find(String.format('li:has("#{0}"):first > a', fid));

	currentNode.addClass('current').attr('href', location.href);

	if (!currentNode.hasClass('color')) {
		// Remove all node with the same name
		currentNode.parent().prevAll(String.format(':contains({0})', currentNode.text())).remove();
	}

	var firstLevelTitle = $(tree).find(String.format('ul[level="1"]:has("#{0}") > li >a', fid)).text();

	var icons = currentSecondLevel.find('[class]');



	icons.filter('.disabled').removeAttr('href').addClass('no-permission').attr('title', '无权访问');

	icons.each(function (i, icon) {
		var text = $(icon).text();
		var classes = icon.className.split(' ');

		if (classes.length == 1 && (classes[0] == 'disabled' || classes[0] == '')) {
			$(icon).removeAttr('class');
		} else {
			$(icon).text('').append(String.format('<span>{0}</span>', text)).addClass('home');
		}

	});


	pnlIcons.append(icons.filter('[class]'));

	var btnShowHomeIconsShortcutPanel = $(String.format('<div id="btnShowHomeIconsShortcutPanel">{0}</div>', firstLevelTitle)); ;

	$('body').append(pnlIcons).append(btnShowHomeIconsShortcutPanel);



	function reposition() {

		Invisible(btnShowHomeIconsShortcutPanel);
		pnlIcons.hide();

		if ($(window).width() < 1420) {
			return;
		}

		setTimeout(function () {

			var contentLeft = $('body .content').offset().left;

			btnShowHomeIconsShortcutPanel.css('left', contentLeft - 40);
			pnlIcons.css('left', btnShowHomeIconsShortcutPanel.offset().left - pnlIcons.width() + 30);
			//			pnlIcons.css('top', btnShowHomeIconsShortcutPanel.offset().top);
			//			Invisible(btnShowHomeIconsShortcutPanel, false);
			pnlIcons.show();
		}, 100);
	}

	reposition();

	$(window).resize(reposition);

	//	pnlIcons.show();

	btnShowHomeIconsShortcutPanel.click(function () {
		pnlIcons.fadeToggle();

	});

	//	HidePanelWhileClickingOutside(btnShowHomeIconsShortcutPanel, pnlIcons);
}

function Invisible(obj, invisible) {
	$(obj).css('visibility', invisible === false ? 'visible' : 'hidden');
}

function SetMinHeightForContentArea() {

	var content = $('div.content');

	var padding = { top: 20, right: 40, bottom: 40, left: 40 };

	initializeContent();

	function setMinHeight() {
		var minHeight = $(window).height() - $('div.header').height() - padding.top - 5 - padding.bottom;
		var contentHeight = content.height();
		content.css('min-height', minHeight > contentHeight ? minHeight : contentHeight);
	}

	function setProperPadding() {

		if ($(window).width() < 1024) {
			padding.left = padding.right = ($(window).width() - content.width()) / 2;
		}

		content.css('padding', String.format('{0}px {1}px {2}px {3}px', padding.top, padding.right, padding.bottom, padding.left));
	}

	function initializeContent() {
		content.removeAttr('style');
		setProperPadding();
		setMinHeight();
		Invisible(content, false);
	}

	$(window).resize(function () {
		var windowHeight = $(window).height();
		if (window.lastHeight === windowHeight) {
			return;
		} else {
			window.lastHeight = windowHeight;
		}
		Invisible(content);

		initializeContent();
	});
}

function PopUpReminderIcons() {

	if ($('#pnlPopUp').length > 0) {
		return;
	}

	var pnlIcons = $('#pnlIcons');
	if (pnlIcons.length === 0) {
		return;
	}

	if ($.cookie('JustLogined')) {
		$.removeCookie('JustLogined', { path: '/' });
	} else {
		return;
	}

	popUpWhenReady();

	function popUpWhenReady() {

		var allReminderIcons = pnlIcons.find('a:has(em)');

		if (allReminderIcons.length == 0) {
			setTimeout(popUpWhenReady, 50);
			return;
		}

		allReminderClonedIcons = allReminderIcons.clone().addClass('pop-up');

		var pnlPopUp = $('<div id="pnlPopUp"></div');

		pnlPopUp.append(allReminderClonedIcons);

		pnlPopUp.dialog({ modal: true, title: '待办事项', width: 334, height: 'auto', dialogClass: 'transparent-dialog', resizable: false });
	}
}

function disabledFormItem(target) {
	target.find(':checkbox, :radio').prop('disabled', true);
	target.find('textarea').prop('readonly', true);
	target.find('button, img.ui-datepicker-trigger, input[type="button"], input[type="submit"]').filter('[value!=搜索]').hide();
}

