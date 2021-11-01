﻿using Bridgefield.PersistentBits.FileSystem;
using Pass.Components.Binding;
using Pass.Components.FileSystem;
using Pass.Components.MessageBus;
using Pass.Components.ViewMapping;
using Pass.Views;

namespace Pass.ViewModels
{
    [View(typeof(MainView))]
    public sealed class MainViewModel : Bindable
    {
        public Bindable Content { get; }

        public MainViewModel(MessageBus messageBus, IDirectory passwordDirectory) =>
            Content = new ContentWithSidebarViewModel(
                null,
                new PasswordListViewModel(new PasswordRepository(passwordDirectory), messageBus),
                messageBus);
    }
}