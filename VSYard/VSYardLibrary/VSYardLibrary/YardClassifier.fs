﻿namespace VSYardNS

open System
open System.Collections.Generic
open System.ComponentModel.Composition
open Microsoft.VisualStudio.Text
open Microsoft.VisualStudio.Text.Classification
open Microsoft.VisualStudio.Text.Editor
open Microsoft.VisualStudio.Text.Tagging
open Microsoft.VisualStudio.Utilities
open System.Linq

//тип должен быть описан перед его использованием
type internal MyClassifier (buffer, ookTagAggregator, ClassificationTypeRegistry) = class
    interface ITagger<ClassificationTag> with
        member self.GetTags (spans:NormalizedSnapshotSpanCollection) : seq<ITagSpan<ClassificationTag>> = Seq.empty
        member self.add_TagsChanged x = ()
        member self.remove_TagsChanged x = ()
 end

[<Export(typeof<ITaggerProvider>)>]
[<ContentType("yard")>]
[<TagType(typeof<ClassificationTag>)>]
type internal YardClassifier () = class
        
        // сперва все let-ы, потом member-ы
        let mutable ookContentType : ContentTypeDefinition = null
        let mutable ookFileType : FileExtensionToContentTypeDefinition = null
        let mutable classificationTypeRegistry : IClassificationTypeRegistryService = null
        let mutable aggregatorFactory : IBufferTagAggregatorFactoryService = null

        [<Export>]
        [<Name("yard")>]
        [<BaseDefinition("code")>]
        member self.OokContentType 
            with get () = ookContentType
            and set oot = ookContentType <- oot

        [<Export>]
        [<FileExtension(".yrd")>]
        [<ContentType("yard")>]        
        member self.OokFileType 
            with get () = ookContentType
            and set oft = ookContentType <- oft

        [<Import>]        
        member self.ClassificationTypeRegistry
            with get () = classificationTypeRegistry
            and set ctr = classificationTypeRegistry <- ctr

        [<Import>]        
        member self.AggregatorFactory 
            with get () = aggregatorFactory
            and set af = aggregatorFactory <- af        

        interface ITaggerProvider with
            member this.CreateTagger(buffer : ITextBuffer) =
                let ookTagAggregator : ITagAggregator<TokenTag> = aggregatorFactory.CreateTagAggregator<TokenTag>(buffer)
                box (MyClassifier(buffer, ookTagAggregator, classificationTypeRegistry)) :?> ITagger<_> 
    end
