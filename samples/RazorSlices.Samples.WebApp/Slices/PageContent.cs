﻿namespace RazorSlices.Samples.WebApp.Slices;

public static class PageContent
{
    public static ReadOnlySpan<byte> Sentence => "Lorem ipsum dolor sit amet ipsum sed feugiat rebum et voluptua autem dolore amet magna."u8;

    public static ReadOnlySpan<byte> Sentences(int count)
    {
        if (count == 1)
        {
            return Sentence;
        }

        var sentenceLength = Sentence.Length;
        // Number of sentences + allowance for space in between each sentence
        var bufferLength = (sentenceLength * count) + (count - 1);
        var output = new byte[bufferLength];
        var outputSpan = output.AsSpan();

        for (int i = 0; i < count; i++)
        {
            if (i > 0)
            {
                // Add leading space
                " "u8.CopyTo(outputSpan);
                outputSpan = outputSpan[1..];
            }
            Sentence.CopyTo(outputSpan);
            outputSpan = outputSpan[Sentence.Length..];
        }

        return output;
    }

    public static ReadOnlySpan<byte> Paragraph => "Lorem ipsum dolor sit amet no sit sit invidunt velit minim lorem et ex adipiscing sanctus sit. Eirmod tincidunt magna feugait praesent erat nonumy et accusam dolor eirmod labore consetetur no tempor eirmod dolor doming est. Aliquip amet dolor dolor accumsan rebum aliquyam tempor tincidunt et ipsum sit gubergren nulla magna commodo ipsum. Aliquyam consectetuer zzril nonumy takimata ut dolor accusam elitr. Veniam ut ipsum ut magna sed ea nonumy nulla dolores. Ipsum et dolores kasd est. Dolor vero delenit lorem est nonumy tincidunt lorem ex. Gubergren vero sit ex labore eos consequat amet in duo. Dolores magna amet. Vero dolore gubergren diam ipsum no dolores dolor eu. Dolor kasd eirmod sed quis eos ut dolores feugait est amet feugiat dolore congue. Facilisis diam duo tempor dolore duo iriure consequat aliquip dolor vero facilisis laoreet. Vero eum consetetur dolore et sed facilisis et lorem erat nonumy et duo accusam. Justo dolore erat magna ea et eos amet wisi takimata clita iusto sed nostrud kasd. Consetetur et nobis diam elit dolor et dolore sea sit takimata molestie. Eros et ut ipsum eirmod. Nisl sed volutpat sea te et sadipscing erat invidunt elitr consequat commodo no."u8;

    public static ReadOnlySpan<byte> Html => """
        <p>Philosophi autem in suis lectulis plerumque moriuntur. Quod, inquit, quamquam voluptatibus quibusdam est saepe iucundius, tamen expetitur propter voluptatem. <mark>Cur iustitia laudatur?</mark> Quae tamen a te agetur non melior, quam illae sunt, quas interdum optines. Non quaero, quid dicat, sed quid convenienter possit rationi et sententiae suae dicere. Nonne odio multos dignos putamus, qui quodam motu aut statu videntur naturae legem et modum contempsisse? Iam argumenti ratione conclusi caput esse faciunt ea, quae perspicua dicunt, deinde ordinem sequuntur, tum, quid verum sit in singulis, extrema conclusio est. <i>Respondeat totidem verbis.</i> Atque haec ita iustitiae propria sunt, ut sint virtutum reliquarum communia. </p>

        <p><a href='http://loripsum.net/' target='_blank'>Eadem fortitudinis ratio reperietur.</a> Nunc dicam de voluptate, nihil scilicet novi, ea tamen, quae te ipsum probaturum esse confidam. Id enim volumus, id contendimus, ut officii fructus sit ipsum officium. Crasso, quem semel ait in vita risisse Lucilius, non contigit, ut ea re minus agelastoj ut ait idem, vocaretur. Estne, quaeso, inquam, sitienti in bibendo voluptas? Minime vero probatur huic disciplinae, de qua loquor, aut iustitiam aut amicitiam propter utilitates adscisci aut probari. </p>

        <p>Et quidem Arcesilas tuus, etsi fuit in disserendo pertinacior, tamen noster fuit; Id enim volumus, id contendimus, ut officii fructus sit ipsum officium. Illud enim rectum est quod katortwma dicebas contingitque sapienti soli, hoc autem inchoati cuiusdam officii est, non perfecti, quod cadere in non nullos insipientes potest. Dicet pro me ipsa virtus nec dubitabit isti vestro beato M. Quis tibi ergo istud dabit praeter Pyrrhonem, Aristonem eorumve similes, quos tu non probas? Atque hoc loco similitudines eas, quibus illi uti solent, dissimillimas proferebas. Ea possunt paria non esse. <b>Cur id non ita fit?</b> <a href='http://loripsum.net/' target='_blank'>Quod cum dixissent, ille contra.</a> Quam ob rem tandem, inquit, non satisfacit? Res tota, Torquate, non doctorum hominum, velle post mortem epulis celebrari memoriam sui nominis. Alterum significari idem, ut si diceretur, officia media omnia aut pleraque servantem vivere. Quia voluptatem hanc esse sentiunt omnes, quam sensus accipiens movetur et iucunditate quadam perfunditur. Et summatim quidem haec erant de corpore animoque dicenda, quibus quasi informatum est quid hominis natura postulet. </p>

        <p><i>Vide, quaeso, rectumne sit.</i> Quid, si non modo utilitatem tibi nullam afferet, sed iacturae rei familiaris erunt faciendae, labores suscipiendi, adeundum vitae periculum? Ut alios omittam, hunc appello, quem ille unum secutus est. Polemoni et iam ante Aristoteli ea prima visa sunt, quae paulo ante dixi. Huic verbo omnes, qui ubique sunt, qui Latine sciunt, duas res subiciunt, laetitiam in animo, commotionem suavem iucunditatis in corpore. Te autem hortamur omnes, currentem quidem, ut spero, ut eos, quos novisse vis, imitari etiam velis. <a href='http://loripsum.net/' target='_blank'>Verum hoc idem saepe faciamus.</a> De quibus cupio scire quid sentias. </p>

        <p>Sequitur disserendi ratio cognitioque naturae; Hoc etsi multimodis reprehendi potest, tamen accipio, quod dant. Qui autem diffidet perpetuitati bonorum suorum, timeat necesse est, ne aliquando amissis illis sit miser. Ita enim vivunt quidam, ut eorum vita refellatur oratio. Iam quae corporis sunt, ea nec auctoritatem cum animi partibus, comparandam et cognitionem habent faciliorem. <a href='http://loripsum.net/' target='_blank'>Invidiosum nomen est, infame, suspectum.</a> </p>

        <p><mark>Duarum enim vitarum nobis erunt instituta capienda.</mark> Voluptatem cum summum bonum diceret, primum in eo ipso parum vidit, deinde hoc quoque alienum; <i>Iam contemni non poteris.</i> <b>Non potes, nisi retexueris illa.</b> A primo, ut opinor, animantium ortu petitur origo summi boni. Tum Torquatus: Prorsus, inquit, assentior; Quodcumque in mentem incideret, et quodcumque tamquam occurreret. Non quaero, quid dicat, sed quid convenienter possit rationi et sententiae suae dicere. Si quicquam extra virtutem habeatur in bonis. <i>Sed videbimus.</i> Intrandum est igitur in rerum naturam et penitus quid ea postulet pervidendum; Cum sciret confestim esse moriendum eamque mortem ardentiore studio peteret, quam Epicurus voluptatem petendam putat. His enim rebus detractis negat se reperire in asotorum vita quod reprehendat. Vide, ne etiam menses! nisi forte eum dicis, qui, simul atque arripuit, interficit. </p>

        <p>Prodest, inquit, mihi eo esse animo. <a href='http://loripsum.net/' target='_blank'>Qua tu etiam inprudens utebare non numquam.</a> Te ipsum, dignissimum maioribus tuis, voluptasne induxit, ut adolescentulus eriperes P. Adsint etiam formosi pueri, qui ministrent, respondeat his vestis, argentum, Corinthium, locus ipse, aedificium-hos ergo asotos bene quidem vivere aut beate numquam dixerim. Experiamur igitur, inquit, etsi habet haec Stoicorum ratio difficilius quiddam et obscurius. Quae hic rei publicae vulnera inponebat, eadem ille sanabat. Sunt autem, qui dicant foedus esse quoddam sapientium, ut ne minus amicos quam se ipsos diligant. <a href='http://loripsum.net/' target='_blank'>Aliter enim explicari, quod quaeritur, non potest.</a> Atqui iste locus est, Piso, tibi etiam atque etiam confirmandus, inquam; Atque ab his initiis profecti omnium virtutum et originem et progressionem persecuti sunt. </p>

        <ul>
            <li>An potest cupiditas finiri?</li>
            <li>Quam multa vitiosa! summum enim bonum et malum vagiens puer utra voluptate diiudicabit, stante an movente?</li>
            <li>Itaque et manendi in vita et migrandi ratio omnis iis rebus, quas supra dixi, metienda.</li>
            <li>Videamus animi partes, quarum est conspectus illustrior;</li>
            <li>Nam ante Aristippus, et ille melius.</li>
        </ul>


        <p><mark>Quis est tam dissimile homini.</mark> <a href='http://loripsum.net/' target='_blank'>Tu quidem reddes;</a> Curium putes loqui, interdum ita laudat, ut quid praeterea sit bonum neget se posse ne suspicari quidem. Haec qui audierit, ut ridere non curet, discedet tamen nihilo firmior ad dolorem ferendum, quam venerat. Vadem te ad mortem tyranno dabis pro amico, ut Pythagoreus ille Siculo fecit tyranno? Nec vero sum nescius esse utilitatem in historia, non modo voluptatem. Quid loquor de nobis, qui ad laudem et ad decus nati, suscepti, instituti sumus? Somnum denique nobis, nisi requietem corporibus et is medicinam quandam laboris afferret, contra naturam putaremus datum; <i>Quonam, inquit, modo?</i> Quos nisi redarguimus, omnis virtus, omne decus, omnis vera laus deserenda est. Haec et tu ita posuisti, et verba vestra sunt. <a href='http://loripsum.net/' target='_blank'>Respondent extrema primis, media utrisque, omnia omnibus.</a> </p>

        <p>Traditur, inquit, ab Epicuro ratio neglegendi doloris. Sic vester sapiens magno aliquo emolumento commotus cicuta, si opus erit, dimicabit. Tum ille timide vel potius verecunde: Facio, inquit. Cum autem paulum firmitatis accessit, et animo utuntur et sensibus conitunturque, ut sese erigant, et manibus utuntur et eos agnoscunt, a quibus educantur. Sin autem est in ea, quod quidam volunt, nihil impedit hanc nostram comprehensionem summi boni. Vidit Homerus probari fabulam non posse, si cantiunculis tantus irretitus vir teneretur; Non ego tecum iam ita iocabor, ut isdem his de rebus, cum L. An eum discere ea mavis, quae cum plane perdidiceriti nihil sciat? Inscite autem medicinae et gubernationis ultimum cum ultimo sapientiae comparatur. Eaedem enim utilitates poterunt eas labefactare atque pervertere. </p>

        <p>Qui autem voluptate vitam effici beatam putabit, qui sibi is conveniet, si negabit voluptatem crescere longinquitate? Tum ille: Tu autem cum ipse tantum librorum habeas, quos hic tandem requiris? <mark>Poterat autem inpune;</mark> Quem quidem vos, cum improbis poenam proponitis, inpetibilem facitis, cum sapientem semper boni plus habere vultis, tolerabilem. Sed id ne cogitari quidem potest quale sit, ut non repugnet ipsum sibi. Non prorsus, inquit, omnisque, qui sine dolore sint, in voluptate, et ea quidem summa, esse dico. Restat locus huic disputationi vel maxime necessarius de amicitia, quam, si voluptas summum sit bonum, affirmatis nullam omnino fore. Quid ergo dubitamus, quin, si non dolere voluptas sit summa, non esse in voluptate dolor sit maximus? Illud autem ipsum qui optineri potest, quod dicitis, omnis animi et voluptates et dolores ad corporis voluptates ac dolores pertinere? Chrysippus autem exponens differentias animantium ait alias earum corpore excellere, alias autem animo, non nullas valere utraque re; Et summatim quidem haec erant de corpore animoque dicenda, quibus quasi informatum est quid hominis natura postulet. Non autem hoc: igitur ne illud quidem. </p>

        <p>Ait enim se, si uratur, Quam hoc suave! dicturum. Maximeque eos videre possumus res gestas audire et legere velle, qui a spe gerendi absunt confecti senectute. Nec tamen ille erat sapiens quis enim hoc aut quando aut ubi aut unde? Nam Pyrrho, Aristo, Erillus iam diu abiecti. Quid ergo dubitamus, quin, si non dolere voluptas sit summa, non esse in voluptate dolor sit maximus? Si est nihil in eo, quod perficiendum est, praeter motum ingenii quendam, id est rationem, necesse est huic ultimum esse virtute agere; </p>

        <p>Roges enim Aristonem, bonane ei videantur haec: vacuitas doloris, divitiae, valitudo; <mark>Res enim concurrent contrariae.</mark> <a href='http://loripsum.net/' target='_blank'>Tu quidem reddes;</a> <i>An potest cupiditas finiri?</i> Intrandum est igitur in rerum naturam et penitus quid ea postulet pervidendum; </p>

        <p>Videsne ut, quibus summa est in voluptate, perspicuum sit quid iis faciendum sit aut non faciendum? Quid ergo dubitamus, quin, si non dolere voluptas sit summa, non esse in voluptate dolor sit maximus? Re mihi non aeque satisfacit, et quidem locis pluribus. Quis animo aequo videt eum, quem inpure ac flagitiose putet vivere? Ex quo illud efficitur, qui bene cenent omnis libenter cenare, qui libenter, non continuo bene. Tu vero, inquam, ducas licet, si sequetur; <a href='http://loripsum.net/' target='_blank'>Refert tamen, quo modo.</a> Nemo nostrum istius generis asotos iucunde putat vivere. <a href='http://loripsum.net/' target='_blank'>A mene tu?</a> Quis suae urbis conservatorem Codrum, quis Erechthei filias non maxime laudat? </p>

        <p>Sed quod proximum fuit non vidit. Et nunc quidem quod eam tuetur, ut de vite potissimum loquar, est id extrinsecus; Cenasti in vita numquam bene, cum omnia in ista Consumis squilla atque acupensere cum decimano. Conferam tecum, quam cuique verso rem subicias; In contemplatione et cognitione posita rerum, quae quia deorum erat vitae simillima, sapiente visa est dignissima. Ut nemo dubitet, eorum omnia officia quo spectare, quid sequi, quid fugere debeant? Nihilne te delectat umquam -video, quicum loquar-, te igitur, Torquate, ipsum per se nihil delectat? <a href='http://loripsum.net/' target='_blank'>Isto modo ne improbos quidem, si essent boni viri.</a> </p>

        <p>Inde sermone vario sex illa a Dipylo stadia confecimus. Itaque, Torquate, cum diceres clamare Epicurum non posse iucunde vivi, nisi honeste et sapienter et iuste viveretur, tu ipse mihi gloriari videbare. Illud autem ipsum qui optineri potest, quod dicitis, omnis animi et voluptates et dolores ad corporis voluptates ac dolores pertinere? Nunc haec primum fortasse audientis servire debemus. <a href='http://loripsum.net/' target='_blank'>At iam decimum annum in spelunca iacet.</a> <mark>Atqui reperies, inquit, in hoc quidem pertinacem;</mark> Illud dico, ea, quae dicat, praeclare inter se cohaerere. Quam ob rem tandem, inquit, non satisfacit? Quoniamque non dubium est quin in iis, quae media dicimus, sit aliud sumendum, aliud reiciendum, quicquid ita fit aut dicitur, omne officio continetur. </p>

        <ul>
            <li>Quae cum praeponunt, ut sit aliqua rerum selectio, naturam videntur sequi;</li>
            <li>Tantum dico, magis fuisse vestrum agere Epicuri diem natalem, quam illius testamento cavere ut ageretur.</li>
            <li>Et ais, si una littera commota sit, fore tota ut labet disciplina.</li>
            <li>Tubulum fuisse, qua illum, cuius is condemnatus est rogatione, P.</li>
        </ul>


        <p>Idem fecisset Epicurus, si sententiam hanc, quae nunc Hieronymi est, coniunxisset cum Aristippi vetere sententia. Cum autem in quo sapienter dicimus, id a primo rectissime dicitur. Ut vero conservetur omnis homini erga hominem societas, coniunctio, caritas, et emolumenta et detrimenta, quae felmata et blammata appellant, communia esse voluerunt; Ab hoc autem quaedam non melius quam veteres, quaedam omnino relicta. Cum autem venissemus in Academiae non sine causa nobilitata spatia, solitudo erat ea, quam volueramus. <a href='http://loripsum.net/' target='_blank'>Proclivi currit oratio.</a> Nisi autem rerum natura perspecta erit, nullo modo poterimus sensuum iudicia defendere. Non enim in selectione virtus ponenda erat, ut id ipsum, quod erat bonorum ultimum, aliud aliquid adquireret. Age nunc isti doceant, vel tu potius quis enim ista melius? Quod cum dixissent, ille contra. Quia, cum a Zenone, inquam, hoc magnifice tamquam ex oraculo editur: Virtus ad beate vivendum se ipsa contenta est, et Quare? </p>

        <p><b>Ipse Epicurus fortasse redderet, ut Sextus Peducaeus, Sex.</b> <mark>Sed quod proximum fuit non vidit.</mark> Legimus tamen Diogenem, Antipatrum, Mnesarchum, Panaetium, multos alios in primisque familiarem nostrum Posidonium. Sin autem est in ea, quod quidam volunt, nihil impedit hanc nostram comprehensionem summi boni. <a href='http://loripsum.net/' target='_blank'>An tu me de L.</a> </p>

        <p>Superiores tres erant, quae esse possent, quarum est una sola defensa, eaque vehementer. Restat locus huic disputationi vel maxime necessarius de amicitia, quam, si voluptas summum sit bonum, affirmatis nullam omnino fore. Quis negat? Gloriosa ostentatio in constituendo summo bono. Nec tamen ille erat sapiens quis enim hoc aut quando aut ubi aut unde? Quis contra in illa aetate pudorem, constantiam, etiamsi sua nihil intersit, non tamen diligat? Cum enim summum bonum in voluptate ponat, negat infinito tempore aetatis voluptatem fieri maiorem quam finito atque modico. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet, ut et voluptates repudiandae sint et molestiae non recusandae. </p>

        <ul>
            <li>Esse enim quam vellet iniquus iustus poterat inpune.</li>
            <li>Quod idem cum vestri faciant, non satis magnam tribuunt inventoribus gratiam.</li>
            <li>Tamen aberramus a proposito, et, ne longius, prorsus, inquam, Piso, si ista mala sunt, placet.</li>
            <li>Restincta enim sitis stabilitatem voluptatis habet, inquit, illa autem voluptas ipsius restinctionis in motu est.</li>
        </ul>
        """u8;
}
