date=`date +"%H.%M"`
name="CSharp"

target="$HOME/Téléchargements/Copies/CP-$name-$date"

if [ ! -d $target ]; then
    mkdir $target

    cp -r Data $target
    cp -r Migrations $target
    cp -r Models $target
    cp -r Pages $target
    cp -r Properties $target
    cp -r Shared $target
    cp -r wwwroot $target

    cp *.razor $target
    cp *.cs* $target
    cp *.js* $target
fi

echo "Copie $name - $date"