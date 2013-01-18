using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Threading;
using DevExpress.Xpf.Grid;

namespace DXHostWizards
{
   public  class CommitHelper
    {
        public static readonly DependencyProperty CommitOnValueChangedProperty = DependencyProperty.RegisterAttached("CommitOnValueChanged", typeof(bool), typeof(CommitHelper), new PropertyMetadata(CommitOnValueChangedPropertyChanged));

        public static void SetCommitOnValueChanged(GridColumn element, bool value)
        {
            element.SetValue(CommitOnValueChangedProperty, value);
        }

        public static bool GetCommitOnValueChanged(GridColumn element)
        {
            return (bool)element.GetValue(CommitOnValueChangedProperty);
        }

        private static void CommitOnValueChangedPropertyChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            GridColumn col = source as GridColumn;
            if (col.View == null)
                Dispatcher.CurrentDispatcher.BeginInvoke(new Action<GridColumn, bool>((column, subscribe) => { ToggleCellValueChanging(column, subscribe); }), col, (bool)e.NewValue);
            else
                ToggleCellValueChanging(col, (bool)e.NewValue);
        }

        private static void ToggleCellValueChanging(GridColumn col, bool subscribe)
        {
            TableView view = col.View as TableView;
            if (view == null)
                return;

            if (subscribe)
                view.CellValueChanging += new CellValueChangedEventHandler(view_CellValueChanging);
            else
                view.CellValueChanging -= view_CellValueChanging;
        }

        static void view_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            TableView view = sender as TableView;
            if ((bool)e.Column.GetValue(CommitOnValueChangedProperty))
                view.PostEditor();
        }
    }
}
