#!/bin/sh

# npm install -g less
lessc "RazorTdesign/wwwroot/_common/style/web/_global.less" > "RazorTdesign/wwwroot/tdesign/global.css"
lessc "RazorTdesign/wwwroot/_common/style/web/_reset.less" > "RazorTdesign/wwwroot/tdesign/reset.css"
lessc "RazorTdesign/wwwroot/_common/style/web/theme/_index.less" > "RazorTdesign/wwwroot/tdesign/theme.css"
lessc "RazorTdesign/wwwroot/_common/style/web/components/button/_index.less" > "RazorTdesign/Components/Button/Button.razor.css"