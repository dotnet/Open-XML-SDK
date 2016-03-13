#!/bin/bash
if [[ "$OS" != "Windows_NT" ]] &&
       [ ! -e ~/.config/.mono/certs ]
then
  mozroots --import --sync --quiet
fi

if [ ! -f packages/FAKE/tools/FAKE.exe ]; then
  mono .nuget/nuget.exe install FAKE -OutputDirectory packages -ExcludeVersion -Source "https://nuget.org/api/v2/"
fi

#workaround assembly resolution issues in build.fsx
export FSHARPI=`which fsharpi`
cat - > fsharpi <<"EOF"
#!/bin/bash
libdir=$PWD/packages/FAKE/tools/
$FSHARPI --lib:$libdir $@
EOF
chmod +x fsharpi
mono packages/FAKE/tools/FAKE.exe Build.fsx $@