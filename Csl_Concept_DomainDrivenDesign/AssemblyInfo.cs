using System.Runtime.InteropServices;

// Dans les projets de type SDK comme celui-là, plusieurs attributs d'assembly définis
// historiquement dans ce fichier sont maintenant automatiquement ajoutés pendant
// la génération et renseignés avec des valeurs définies dans les propriétés du projet.
// Pour plus d'informations sur les attributs à inclure et sur la personnalisation
// de ce processus, consultez : https://aka.ms/assembly-info-properties


// La définition de ComVisible sur False rend les types dans cet assembly invisibles
// aux composants COM. Si vous devez accéder à un type dans cet assembly à partir
// de COM, définissez l'attribut ComVisible sur True pour ce type.

[assembly: ComVisible(false)]

// Le GUID suivant concerne l'ID de typelib si ce projet est exposé à COM.
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]
[assembly: Guid("6fb61602-bd9c-4bbc-a446-cb1507823c59")]

