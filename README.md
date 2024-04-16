# CircularWPF

Simple example — how to use WPF Control in LabVIEW.

![](assets/Snippet.png)

Result:

![](assets/CircularWPF.gif)

Base WPF Code was taken from [Code Samples](https://crudzone.wordpress.com/wpf/).

Project is dependent on two packages from nuget:

"Expression.Blend.Sdk.WPF" version="1.0.1"
"Microsoft.SDK.Expression.Blend" version="1.0.0"
Target framework  is "net48".
LabVIEW Code saved in  2018.

### Troubleshooting

If you see the following message:

![image-20240416173458763](assets\image-20240416173458763.png)

Then probably you open Circular.vi without project like "stand alone". Try to open Circular.lvproj file first,m then open VI from the project:

![image-20240416173658891](assets\image-20240416173658891.png)

