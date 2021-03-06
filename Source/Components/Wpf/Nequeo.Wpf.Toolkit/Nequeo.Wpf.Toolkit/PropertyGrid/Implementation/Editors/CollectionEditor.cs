﻿/*************************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2007-2013 Nequeo Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up the Plus Edition at http://Nequeo.com/wpf_toolkit

   Stay informed: follow @datagrid on Twitter or Like http://facebook.com/datagrids

  ***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Nequeo.Wpf.Toolkit.PropertyGrid.Editors
{
  public class CollectionEditor : TypeEditor<CollectionControlButton>
  {
    protected override void SetValueDependencyProperty()
    {
      ValueProperty = CollectionControlButton.ItemsSourceProperty;
    }

    protected override void ResolveValueBinding( PropertyItem propertyItem )
    {
      var type = propertyItem.PropertyType;

      Editor.ItemsSourceType = type;

      if( type.BaseType == typeof( System.Array ) )
      {
        Editor.NewItemTypes = new List<Type>() { type.GetElementType() };
      }
      else if( type.GetGenericArguments().Count() > 0 )
      {
        Editor.NewItemTypes = new List<Type>() { type.GetGenericArguments()[ 0 ] };
      }

      base.ResolveValueBinding( propertyItem );
    }
  }

  public class PropertyGridEditorCollectionControl : CollectionControlButton
  {
    static PropertyGridEditorCollectionControl()
    {
      DefaultStyleKeyProperty.OverrideMetadata( typeof( PropertyGridEditorCollectionControl ), new FrameworkPropertyMetadata( typeof( PropertyGridEditorCollectionControl ) ) );
    }
  }
}
