project('gtk-sharp-meson-template', 'cs',
  meson_version: '>= 0.43.0'
)

gtk_sharp_dep = dependency('gtk-sharp-3.0',
  fallback: ['gtk-sharp', 'gtk_sharp_dep']
)

executable('gtk-application', 'main.cs',
  dependencies: gtk_sharp_dep,
  install: true
)