//using System;
//using DicasXamariniOS.iOS;
//using UIKit;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.iOS;

//[assembly: ExportRenderer(typeof(ViewCell), typeof(ViewCellTransparent))]
//namespace DicasXamariniOS.iOS
//{
//    public class ViewCellTransparent : ViewCellRenderer
//    {
//        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
//        {
//            var cell = base.GetCell(item, reusableCell, tv);
//            if (cell != null)
//            {
//                // Disable native cell selection color style - set as *Transparent*
//                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
//            }
//            return cell;


//        }
//    }
//}